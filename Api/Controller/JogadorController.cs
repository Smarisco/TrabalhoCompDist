using System;
using System.Web.Http;
using TrabalhoCompDist.Interfaces.Services;

namespace Api.Controller
{
    public class JogadorController
    {
        [RoutePrefix("api/jogador")]
        public class JogadorController : ApiController
        {
            private readonly IServiceJogador _serviceJogador;

            public JogadorController(IUnityTrabalho unityTrabalho, IServiceJogador serviceJogador) : base(unityTrabalho)
            {
                _serviceJogador = serviceJogador;
            }

            [Route("Adicionar")]
            [HttpPost]
            public async Task<HttpResponseMessage> Adicionar(AdicionarJogadorRequest request)
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