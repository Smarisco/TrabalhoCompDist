using System;
using TrabalhoCompDist.Arguments.Jogador;
using TrabalhoCompDist.Entities;
using TrabalhoCompDist.Interfaces.Repositories;
using TrabalhoCompDist.Interfaces.Services;
using TrabalhoCompDist.ValueObjects;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using TrabalhoCompDist.Recursos;
using System.Collections.Generic;
using System.Linq;
using prmToolkit.NotificationPattern.Resources;

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
            if (request == null)
            {
                AddNotification("AlterarJogador", Mensagens.X0_E_OBRIGATORIO.ToFormat("Campo"));
            }

            //trazer informações do banco de dados
            Jogador jogador = _repositoryJogador.ObterJogadorPorId(request.Id);
            if (jogador == null)
            {
                AddNotification("Id", Mensagens.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);
            
            jogador.AlterarJogador(nome, email, jogador.Status);
                                    
            AddNotifications(jogador);

            if (IsInvalid())
            {
                return null;
            }

             _repositoryJogador.AlterarJogador(jogador);
            
            return (AlterarJogadorResponse)jogador;
        }


        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarJogador", Mensagens.X0_E_OBRIGATORIO.ToFormat(" "));
            }

            var email = new Email(request.Email);
            var jogador = new Jogador(email, request.Senha);

            AddNotifications(jogador, email);

            if (jogador.IsInvalid())
            {
                return null;
            }

            jogador = _repositoryJogador.ObterPor(x => x.Email.Endereco == jogador.Email.Endereco && x.Senha == jogador.Senha);

            return (AutenticarJogadorResponse)jogador;

        }
        public IEnumerable<JogadorResponse> ListarJogador()
        {
            return _repositoryJogador.ListarJogador().ToList().Select(jogador => (JogadorResponse)jogador).ToList();
        }

    }
}


