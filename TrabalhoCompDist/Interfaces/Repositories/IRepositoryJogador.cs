using System;
using TrabalhoCompDist.Arguments.Jogador;
using TrabalhoCompDist.Entities;

namespace TrabalhoCompDist.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(string email, string senha);
        Guid AdicionarJogador(Jogador jogador);
    }
}
