using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCompDist.Arguments.Base;
using TrabalhoCompDist.Arguments.Jogo;
using TrabalhoCompDist.Entities;
using TrabalhoCompDist.Interfaces.Repositories;
using TrabalhoCompDist.Interfaces.Services;
using TrabalhoCompDist.Recursos;

namespace TrabalhoCompDist.Services
{
    public class ServiceJogo : Notifiable, IServiceJogo
    {
        private readonly IRepositoryJogo _repositoryJogo;
        public ServiceJogo()
        {

        }

        public ServiceJogo(IRepositoryJogo repositoryJogo)
        {
            _repositoryJogo = repositoryJogo;
        }

        public AdiconarJogoResponse AdicionarJogo(AdicionarJogoRequest request)
        {
            if (request == null)
            {
                AddNotification("Adicionar", Mensagens.X0_E_OBRIGATORIO.ToFormat("Campo"));
                return null;
            }

            var jogo = new Jogos(request.Nome, request.Descricao, request.Produtora, request.Distribuidora, request.Genero, request.Site);

            AddNotifications(jogo);

            if (this.IsInvalid())
            {
                return null;
            }

            jogo = _repositoryJogo.Adicionar(jogo);


            return (AdiconarJogoResponse)jogo;
        }

        public ResponseBase AlterarJogo(AlterarJogoResquest request)
        {
            if (request == null)
            {
                AddNotification("Alterar", Mensagens.X0_E_OBRIGATORIO.ToFormat("Campo"));
                return null;
            }

            var jogo = _repositoryJogo.ObterPorId(request.Id);

            if (jogo == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            jogo.Alterar(request.Nome, request.Descricao, request.Produtora, request.Distribuidora, request.Genero, request.Site);

            if (IsInvalid())
            {
                return null;
            }

            _repositoryJogo.Editar(jogo);

            return (ResponseBase)jogo;
        }

        public ResponseBase ExcluirJogo(Guid id)
        {
            var jogo = _repositoryJogo.ObterPorId(id);

            if (jogo == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            _repositoryJogo.Remover(jogo);

            return new ResponseBase() { Message = Message.OPERACAO_REALIZADA_COM_SUCESSO };
        }

        public IEnumerable<JogoResponse> ListarJogo()
        {
            return _repositoryJogo.Listar().ToList().Select(jogo => (JogoResponse)jogo).ToList();
        }
    }
}
