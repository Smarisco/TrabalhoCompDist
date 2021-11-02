using System.Data.Entity.ModelConfiguration;
using TrabalhoCompDist.Entities;

namespace Infraestrutura.Persistencia.Mapping
{
    public class MappingJogoDaPlataforma : EntityTypeConfiguration<JogoDaPlataforma>
    {
        public MappingJogoDaPlataforma()
        {
            ToTable("JogoDaPlataforma");
        }
    }
}
