using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json;
using System;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using TrabalhoCompDist.Arguments.Jogador;
using TrabalhoCompDist.Interfaces.Services;
using Unity;


namespace Api.Security
{
    public class Autorizacao : OAuthAuthorizationServerProvider
    {
        private readonly UnityContainer _container;

        public Autorizacao(UnityContainer container)
        {
            _container = container;
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            return Task.CompletedTask;
        }

        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            try
            {
                IServiceJogador serviceJogador = _container.Resolve<IServiceJogador>();


                AutenticarJogadorRequest request = new AutenticarJogadorRequest();
                request.Email = context.UserName;
                request.Senha = context.Password;

                AutenticarJogadorResponse response = serviceJogador.AutenticarJogador(request);



                if (serviceJogador.IsInvalid())
                {
                    if (response == null)
                    {
                        context.SetError("invalid_grant", "Preencha um e-mail válido e uma senha com pelo menos 6 caracteres.");
                        return Task.CompletedTask;
                    }
                }

                serviceJogador.ClearNotifications();

                if (response == null)
                {
                    context.SetError("invalid_grant", "Jogador não encontrado!");
                    return Task.CompletedTask;
                }

                var identity = new ClaimsIdentity(context.Options.AuthenticationType);

                //Definindo as Claims
                identity.AddClaim(new Claim("Jogador", JsonConvert.SerializeObject(response)));

                var principal = new GenericPrincipal(identity, new string[] { });

                Thread.CurrentPrincipal = principal;

                context.Validated(identity);
            }
            catch (Exception ex)
            {
                context.SetError("invalid_grant", ex.Message);
                return Task.CompletedTask;
            }

            return Task.CompletedTask;
        }
    }
}