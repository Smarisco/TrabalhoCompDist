using TrabalhoCompDist.Interfaces.Dto;

namespace TrabalhoCompDist.Arguments.Jogador
{
    public class AutenticarJogadorRequest:IRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
