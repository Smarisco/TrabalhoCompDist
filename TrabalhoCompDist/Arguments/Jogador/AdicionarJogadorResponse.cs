using System;
using TrabalhoCompDist.Interfaces.Dto;

namespace TrabalhoCompDist.Arguments.Jogador
{
    public class AdicionarJogadorResponse:IResponse
    {
        public Guid Id { get; set; }
        public string Mensagem { get; set; }
    }
}
