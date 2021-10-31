using TrabalhoCompDist.Interfaces.Dto;
using TrabalhoCompDist.ValueObjects;

namespace TrabalhoCompDist.Arguments.Jogador
{
    public class AdicionaJogadorRequest : IRequest
    {
        public string Email { get; set; }
        public string Senha { get;  set; }
        public string PrimeiroNome { get;  set; }
        public string UltimoNome { get;  set; }

    }
}
