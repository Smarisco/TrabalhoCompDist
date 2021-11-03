using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCompDist.Interfaces.Dto;
using TrabalhoCompDist.Recursos;

namespace TrabalhoCompDist.Arguments.Jogo
{
    public class AdiconarJogoResponse 
    {
        public Guid Id { get; set; }

        public string Message { get; set; }

        public static explicit operator AdiconarJogoResponse(Entities.Jogos entidade)
        {
            return new AdiconarJogoResponse()
            {
                Id = entidade.Id,
                Message = Mensagens.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
