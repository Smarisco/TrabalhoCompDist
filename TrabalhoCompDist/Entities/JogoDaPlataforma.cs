using System;

namespace TrabalhoCompDist.Entities
{
    public class JogoDaPlataforma
    {
        public Guid Id { get; set; }
        public Jogos Jogos { get; set; }
        public Plataforma Plataforma { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
