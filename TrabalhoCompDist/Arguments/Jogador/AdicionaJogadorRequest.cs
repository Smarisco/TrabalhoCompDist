using TrabalhoCompDist.Interfaces.Dto;
using TrabalhoCompDist.ValueObjects;

namespace TrabalhoCompDist.Arguments.Jogador
{
    public class AdicionaJogadorRequest:IRequest
    {
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; private set; }
    }
}
