using System;
using TrabalhoCompDist.Interfaces.Dto;

namespace TrabalhoCompDist.Arguments.Jogador
{
    public class AdicionarJogadorResponse:IResponse
    {
        public Guid Id { get; set; }
        public string Mensagem { get; set; }

        public static explicit operator AdicionarJogadorResponse(Entities.Jogador entidade)
        {
            return new AdicionarJogadorResponse()
            {
                Id = entidade.Id,
                Mensagem = TrabalhoCompDist.Recursos.Mensagens.OPERACAO_REALIZADA_COM_SUCESSO

            };
        }
    }
}
