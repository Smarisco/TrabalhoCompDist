using Infra.Repositorio.Base;
using System;
using System.Guid;
using TrabalhoCompDist.Entities;
using TrabalhoCompDist.Interfaces.Repositories;

namespace Infra.Persistencia.Repositorio
{
    public class RepositoryJogador : RepositoryBase<Jogador, Guid>, IRepositoryJogador
    {
        protected readonly Contexto _context;

        public RepositoryJogador(Contexto context) : base(context)
        {
            _context = context;
        }

    }
}
