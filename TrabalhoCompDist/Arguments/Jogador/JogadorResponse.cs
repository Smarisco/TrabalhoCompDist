using System;
using TrabalhoCompDist.Enum;

namespace TrabalhoCompDist.Arguments.Jogador
{
    public class JogadorResponse
    {
        public Guid Id { get; set; }
        public string NomeCompleto { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public EnumStatusJogador Status { get; set; }

        public static explicit operator JogadorResponse(Entities.Jogador entidade)
        {
            return new JogadorResponse()
            {
                Email = entidade.Email.Endereco,
                PrimeiroNome = entidade.Nome.PrimeiroNome,
                UltimoNome = entidade.Nome.UltimoNome,
                Id = entidade.Id,
                NomeCompleto = entidade.ToString(),
                Status = entidade.Status

            };
        }
    }
}
