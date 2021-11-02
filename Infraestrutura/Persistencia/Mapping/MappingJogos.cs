using System.Data.Entity.ModelConfiguration;
using TrabalhoCompDist.Entities;

namespace Infraestrutura.Persistencia.Mapping
{
    public class MappingJogos : EntityTypeConfiguration<Jogos>
    {
        public MappingJogos()
        {
            ToTable("Jogos");

            Property(p => p.NomeJogo)
                .HasMaxLength(256)
                     .IsRequired();
            Property(p => p.DescricaoJogo)
                     .HasMaxLength(256)
                     .IsRequired();

            Property(p => p.Produtora)
                     .HasMaxLength(256)
                     .IsRequired();
                     
            Property(p => p.Genero)
                     .IsRequired();

            Property(p => p.Site)
                .HasMaxLength(256);
                     
        }
    }
        
}

