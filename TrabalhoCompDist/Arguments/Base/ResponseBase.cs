using TrabalhoCompDist.Recursos;

namespace TrabalhoCompDist.Arguments.Base
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Mensagem = TrabalhoCompDist.Recursos.Mensagens.OPERACAO_REALIZADA_COM_SUCESSO;
        }
        public string Mensagem { get; set; }
        public static explicit operator ResponseBase(Entities.Jogos entidade)
        {
            return new ResponseBase()
            {
                Message = Mensagens.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
