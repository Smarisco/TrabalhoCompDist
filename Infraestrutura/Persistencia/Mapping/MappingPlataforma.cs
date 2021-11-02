using System.Data.Entity.ModelConfiguration;
using TrabalhoCompDist.Entities;

namespace Infraestrutura.Persistencia.Mapping
{
    class MappingPlataforma : EntityTypeConfiguration<Plataforma>
    {
        public MappingPlataforma()
        {
            ToTable("Plataforma");
                        
            Property(p => p.NomePlataforma)
                 .HasMaxLength(256)
                 .IsRequired()
                 .HasColumnName("NomePlataforma");
        }
    }
}
