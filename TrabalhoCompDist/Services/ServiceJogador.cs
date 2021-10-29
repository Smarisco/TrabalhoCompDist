using System;
using TrabalhoCompDist.Arguments.Jogador;
using TrabalhoCompDist.Entities;
using TrabalhoCompDist.Interfaces.Repositories;
using TrabalhoCompDist.Interfaces.Services;
using TrabalhoCompDist.ValueObjects;
using prmToolkit.NotificationPattern;
using TrabalhoCompDist.Recursos;

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
            Jogador jogador = new Jogador();

            jogador.Email = request.Email;

            jogador.Nome = request.Nome;

            jogador.Status = Enum.EnumStatusJogador.EmAndamento;

            Guid id = _repositoryJogador.AdicionarJogador(jogador);

            return new AdicionarJogadorResponse() { Id = id, Mensagem = "Operação realizada com sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("Autenticar Jogador ", string.Format(Mensagens.X0_E_OBRIGATORIO, "Autenticar Jogador "));
            }

            var email = new Email(request.Email);

            var jogador = new Jogador(email,request.Senha);

            AddNotifications(jogador,email);

            if (jogador.IsInvalid())
            {
                return null;
            }

            var response = _repositoryJogador.AutenticarJogador(jogador.Email.Endereco,jogador.Senha);

            return response;

        }

        private bool IsEmail(string email)
        {
            return false;
        }
    }
}
