using System;
using TrabalhoCompDist.Arguments.Jogador;
using TrabalhoCompDist.Entities;

namespace TrabalhoCompDist.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        Guid AdicionarJogador(Jogador jogador);
    }
}
