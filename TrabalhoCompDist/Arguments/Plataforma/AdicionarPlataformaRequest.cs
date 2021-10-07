using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCompDist.Interfaces.Dto;

namespace TrabalhoCompDist.Arguments.Plataforma
{
    public class AdicionarPlataformaRequest:IRequest
    {
        public string Nome { get; set; }
    }
}
