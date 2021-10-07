using System;

namespace TrabalhoCompDist.Entities
{
    public class ControleDeJogos
    {
        public Guid Id { get; set; }
        public JogoDaPlataforma JogoPlataforma { get; set; }
        //quais jogos desejo adquirir
        public bool Adquirir { get; set; }
        public DateTime DataAdquirir { get; set; }
        public bool Troco { get; set; }
        public bool Vendo { get; set; }
    }
}
