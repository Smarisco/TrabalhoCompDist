using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhoCompDist.Arguments.Base;
using TrabalhoCompDist.Arguments.Jogador;
using TrabalhoCompDist.Entities;
using TrabalhoCompDist.Interfaces.Repositories;
using TrabalhoCompDist.Interfaces.Services;
using TrabalhoCompDist.Recursos;
using TrabalhoCompDist.ValueObjects;

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

            jogador = _repositoryJogador.Adicionar(jogador);

            return (AdicionarJogadorResponse)jogador;
        }

        public AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AlterarJogador", Mensagens.X0_E_OBRIGATORIO.ToFormat("Campo"));
            }

            //trazer informações do banco de dados
            Jogador jogador = _repositoryJogador.ObterPorId(request.Id);
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

            _repositoryJogador.ObterPor(x => x.Email.Endereco == jogador.Email.Endereco && x.Senha == jogador.Senha);

            return (AutenticarJogadorResponse)jogador;

        }

        public IEnumerable<JogadorResponse> ListarJogador()
        {
            return _repositoryJogador.Listar().Select(jogador => (JogadorResponse)jogador).ToList();
        }

        public ResponseBase ExcluirJogador(Guid id)
        {
            Jogador jogador = _repositoryJogador.ObterPorId(id);
            if (jogador == null)
            {
                AddNotification("Id", Mensagens.DADOS_NAO_ENCONTRADOS);
                return null;
            }
            _repositoryJogador.Remover(jogador);

            return new ResponseBase();

        }
    }
}


