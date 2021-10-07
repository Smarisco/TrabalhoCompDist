using TrabalhoCompDist.Arguments.Jogador;

namespace TrabalhoCompDist.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        AdicionarJogadorResponse AdicionarJogador(AdicionaJogadorRequest request);
    }
}
