using Api.Controller.Base;
using Infra.Transacao;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TrabalhoCompDist.Arguments.Jogador;
using TrabalhoCompDist.Interfaces.Services;

namespace Api.Controller
{
    [RoutePrefix("api/jogador")]
    public class JogadorController : ControllerBase
    {       
        private readonly IServiceJogador _serviceJogador;

        public JogadorController(IUnityTrabalho unityTrabalho, IServiceJogador serviceJogador) : base(unityTrabalho)
        {
            _serviceJogador = serviceJogador;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionaJogadorRequest request)
        {
            try
            {
                var response = _serviceJogador.AdicionarJogador(request);

                return await ResponseAsync(response, _serviceJogador);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _serviceJogador.ListarJogador();

                return await ResponseAsync(response, _serviceJogador);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}