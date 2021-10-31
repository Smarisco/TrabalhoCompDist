﻿using System;
using System.Collections.Generic;
using TrabalhoCompDist.Entities;

namespace TrabalhoCompDist.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(string email, string senha);
        Jogador AdicionarJogador(Jogador jogador);
        IEnumerable<Jogador> ListarJogador();
        Jogador ObterJogadorPorId(Guid id);
        void AlterarJogador(Jogador jogador);
    }
}
