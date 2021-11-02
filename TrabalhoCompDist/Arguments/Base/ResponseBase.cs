namespace TrabalhoCompDist.Arguments.Base
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Mensagem = TrabalhoCompDist.Recursos.Mensagens.OPERACAO_REALIZADA_COM_SUCESSO;
        }
        public string Mensagem { get; set; }
    }
}
