using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCompDist.Entities;

namespace Infra.Persistencia.Mapping
{
    public class MappingJogador : EntityTypeConfiguration<Jogador>
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
