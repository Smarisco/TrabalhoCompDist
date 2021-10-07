using System;
using TrabalhoCompDist.Interfaces.Dto;

namespace TrabalhoCompDist.Arguments.Plataforma
{
    public class AdicionarPlataformaResponse:IResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Mensagem { get; set; }
    }
}
