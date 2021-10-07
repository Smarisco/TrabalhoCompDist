using System;

namespace TrabalhoCompDist.Entities
{
    public class Jogos
    {
        public Guid Id { get; set; }
        public string NomeJogo { get; set; }
        public string DescriçãoJogo { get; set; }
        public string Produtora { get; set; }
        public string Distribuidora { get; set; }
        public string Genero { get; set; }
        public string Site { get; set; }
    }
}
