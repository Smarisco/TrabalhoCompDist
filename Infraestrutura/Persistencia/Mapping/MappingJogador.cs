using System.Data.Entity.ModelConfiguration;
using TrabalhoCompDist.Entities;

namespace Infraestrutura.Persistencia.Mapping
{
    class MappingJogador : EntityTypeConfiguration<Jogador>
    {
        public MappingJogador()
        {
            ToTable("Jogador");

            Property(p => p.Email.Endereco)
                 .HasMaxLength(256)
                 .IsRequired();
            Property(p => p.Nome.PrimeiroNome)
                 .HasMaxLength(256)
                 .IsRequired()
                 .HasColumnName("PrimeiroNome");
            Property(p => p.Nome.UltimoNome)
                 .HasMaxLength(256)
                 .IsRequired()
                 .HasColumnName("UltimoNome"); 
            Property(p => p.Senha)
                 .IsRequired();
            Property(p => p.Status)
                 .IsRequired();

        }
    }
}


