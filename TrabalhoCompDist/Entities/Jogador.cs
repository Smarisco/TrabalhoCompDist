using System;
using TrabalhoCompDist.Enum;
using TrabalhoCompDist.ValueObjects;

namespace TrabalhoCompDist.Entities
{
    public class Jogador
    {
        public Guid Id { get; set; }
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; private set; }
        public EnumStatusJogador Status { get; set; }
    }
}
