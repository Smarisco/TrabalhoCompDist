using System;
using TrabalhoCompDist.Arguments.Jogador;

namespace TrabalhoCompDist.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        Guid AdicionarJogador(AdicionaJogadorRequest request);
    }
}
