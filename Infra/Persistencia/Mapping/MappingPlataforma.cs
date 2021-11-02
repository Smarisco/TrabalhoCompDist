using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCompDist.Entities;

namespace Infra.Persistencia.Mapping
{
    public class MappingPlataforma : EntityTypeConfiguration<Plataforma>
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
