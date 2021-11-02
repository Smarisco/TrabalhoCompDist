using Infra.Transacao;
using System.Web.Http;
using TrabalhoCompDist.Interfaces.Services.Base;

namespace Api.Controller.Base
{
    public class ControllerBase:ApiController
    {
        private readonly IUnityTrabalho _uniTrabalho;
        private IServiceBase _serviceBase;

        public ControllerBase(IUnityTrabalho _uniTrabalho)
        {
            _uniTrabalho = _uniTrabalho;
        }
    }
}