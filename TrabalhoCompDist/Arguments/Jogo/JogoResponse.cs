using System;
using TrabalhoCompDist.Entities;
using TrabalhoCompDist.Interfaces.Dto;

namespace TrabalhoCompDist.Arguments.Jogo
{
    public class JogoResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Produtora { get; set; }

        public string Distribuidora { get; set; }

        public string Genero { get; set; }

        public string Site { get; set; }

        public static explicit operator JogoResponse(Entities.Jogos entidade)
        {
            return new JogoResponse()
            {
                Descricao = entidade.DescricaoJogo,
                Distribuidora = entidade.Distribuidora,
                Genero = entidade.Genero,
                Id = entidade.Id,
                Nome = entidade.NomeJogo,
                Produtora = entidade.Produtora,
                Site = entidade.Site
            };
        }

    }
}
