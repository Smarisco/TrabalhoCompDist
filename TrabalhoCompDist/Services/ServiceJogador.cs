using System;
using TrabalhoCompDist.Arguments.Jogador;
using TrabalhoCompDist.Entities;
using TrabalhoCompDist.Interfaces.Repositories;
using TrabalhoCompDist.Interfaces.Services;
using TrabalhoCompDist.ValueObjects;
using prmToolkit.NotificationPattern;
using TrabalhoCompDist.Recursos;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoCompDist.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        //inversão de controle
        private readonly IRepositoryJogador _repositoryJogador;
        public ServiceJogador()
        {

        }

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }
        public AdicionarJogadorResponse AdicionarJogador(AdicionaJogadorRequest request)
        {
            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);

            var email = new Email(request.Email);

            Jogador jogador = new Jogador(nome, email, request.Senha);

            if (jogador.IsInvalid())
            {
                return null;
            }

          jogador = _repositoryJogador.AdicionarJogador(jogador);

            return (AdicionarJogadorResponse)jogador;
        }

        public AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request)
        {
            throw new NotImplementedException();
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("Autenticar Jogador ", string.Format(Mensagens.X0_E_OBRIGATORIO, "Autenticar Jogador "));
            }

            var email = new Email(request.Email);

            var jogador = new Jogador(email, request.Senha);

            AddNotifications(jogador, email);

            if (jogador.IsInvalid())
            {
                return null;
            }

            jogador = _repositoryJogador.AutenticarJogador(jogador.Email.Endereco, jogador.Senha);

            return (AutenticarJogadorResponse)jogador;

        }

        public IEnumerable<JogadorResponse> ListarJogador()
        {
            return _repositoryJogador.ListarJogador().ToList().Select(jogador=>(JogadorResponse)jogador).ToList();
        }
       
    }
}
