using Infraestrutura.Persistencia.Repositorio.Base;
using System;
using TrabalhoCompDist.Entities;
using TrabalhoCompDist.Interfaces.Repositories;

namespace Infraestrutura.Persistencia.Repositorio
{
    public class RepositoryJogo : RepositoryBase<Jogador, Guid>, IRepositoryJogador
    {
        protected readonly Contexto _context;

        public RepositoryJogo(Contexto context) : base(context)
        {
            _context = context;
        }

    }
}
