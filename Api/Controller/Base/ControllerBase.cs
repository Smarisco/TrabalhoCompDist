using Infra.Transacao;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TrabalhoCompDist.Interfaces.Services.Base;

namespace Api.Controller.Base
{
    public class ControllerBase:ApiController
    {
        private readonly IUnityTrabalho _uniTrabalho;
        private IServiceBase _serviceBase;

        public ControllerBase(IUnityTrabalho uniTrabalho)
        {
            _uniTrabalho = uniTrabalho;
        }
        public async Task<HttpResponseMessage> ResponseAsync(object result, IServiceBase serviceBase)
        {
            _serviceBase = serviceBase;

            if (!serviceBase.Notifications.Any())
            {
                try
                {
                    _uniTrabalho.Commit();

                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                catch (Exception ex)
                {
                    // Aqui devo logar o erro
                    return Request.CreateResponse(HttpStatusCode.Conflict, $"Houve um problema interno com o servidor. Entre em contato com o Administrador do sistema caso o problema persista. Erro interno: {ex.Message}");
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { errors = serviceBase.Notifications });
            }
        }

        public async Task<HttpResponseMessage> ResponseExceptionAsync(Exception ex)
        {
            return Request.CreateResponse(HttpStatusCode.InternalServerError, new { errors = ex.Message, exception = ex.ToString() });
        }

        protected override void Dispose(bool disposing)
        {
            //Realiza o dispose no serviço para que possa ser zerada as notificações
            if (_serviceBase != null)
            {
                _serviceBase.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}