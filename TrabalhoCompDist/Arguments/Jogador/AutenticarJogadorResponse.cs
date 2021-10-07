using TrabalhoCompDist.Interfaces.Dto;
using TrabalhoCompDist.ValueObjects;

namespace TrabalhoCompDist.Arguments.Jogador
{
    public class AutenticarJogadorResponse:IResponse
    {
        public string PrimeiroNome { get; set; }
        public string Email { get; set; }
    }
}
