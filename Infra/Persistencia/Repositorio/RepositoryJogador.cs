using Infra.Repositorio.Base;
using System;
using TrabalhoCompDist.Entities;
using TrabalhoCompDist.Interfaces.Repositories;

namespace Infra.Persistencia.Repositorio
{
    class RepositoryJogador : RepositoryBase<Jogador, Guid>, IRepositoryJogador
    {
        protected readonly Contexto _context;

        public RepositoryJogador(Contexto context) : base(context)
        {
            _context = context;
        }

    }
}
