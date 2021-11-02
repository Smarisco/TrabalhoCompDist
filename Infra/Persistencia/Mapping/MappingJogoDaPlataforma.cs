using System.Data.Entity.ModelConfiguration;
using TrabalhoCompDist.Entities;

namespace Infra.Persistencia.Mapping
{
    public class MappingJogoDaPlataforma : EntityTypeConfiguration<JogoDaPlataforma>
    {
        public MappingJogoDaPlataforma()
        {
            ToTable("JogoDaPlataforma");
        }
    }
}
