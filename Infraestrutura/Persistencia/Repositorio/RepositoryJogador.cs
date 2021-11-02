using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TrabalhoCompDist.Entities;
using TrabalhoCompDist.Interfaces.Repositories;
using System.Data.Entity;

namespace Infraestrutura.Persistencia.Repositorio
{
    public class RepositoryJogador: IRepositoryJogador
    {
        protected readonly Contexto _context;

        public RepositoryJogador(Contexto context)
        {
            _context = context;
        }

        public Jogador Adicionar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
            _context.SaveChanges();
            return jogador;
        }

        public Jogador AdicionarJogador(Jogador jogador)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jogador> AdicionarLista(IEnumerable<Jogador> entidades)
        {
            throw new NotImplementedException();
        }

        public void AlterarJogador(Jogador jogador)
        {
            throw new NotImplementedException();
        }

        public Jogador AutenticarJogador(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Jogador Editar(Jogador entidade)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Func<Jogador, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Jogador> Listar(params Expression<Func<Jogador, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Jogador> ListarEOrdenadosPor<TKey>(Expression<Func<Jogador, bool>> where, Expression<Func<Jogador, TKey>> ordem, bool ascendente = true, params Expression<Func<Jogador, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jogador> ListarJogador()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Jogador> ListarOrdenadosPor<TKey>(Expression<Func<Jogador, TKey>> ordem, bool ascendente = true, params Expression<Func<Jogador, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Jogador> ListarPor(Expression<Func<Jogador, bool>> where, params Expression<Func<Jogador, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Jogador ObterJogadorPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Jogador ObterPor(Func<Jogador, bool> where, params Expression<Func<Jogador, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Jogador ObterPorId(Guid id, params Expression<Func<Jogador, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Remover(Jogador entidade)
        {
            throw new NotImplementedException();
        }

        //public int CalculaJogadores(Jogador jogador)
        //{

        //    IQueryable<Jogador> jogadores = _context.Jogadores.AsQueryable();

        //    if (!string.IsNullOrEmpty(jogador.Nome.PrimeiroNome))
        //    {
        //        jogadores = jogadores.Where(x => x.Nome.PrimeiroNome.StartsWith(jogador.Nome.PrimeiroNome));
        //    }
        //    if (!string.IsNullOrEmpty(jogador.Nome.UltimoNome))
        //    {
        //        jogadores = jogadores.Where(x => x.Nome.UltimoNome.StartsWith(jogador.Nome.UltimoNome));
        //    }

        //    return jogadores.AsParallel().ToList().Count();
        //}

    }
}
