using System.Data.Entity.ModelConfiguration;
using TrabalhoCompDist.Entities;

namespace Infraestrutura.Persistencia.Mapping
{
    public class MappingControleDeJogos : EntityTypeConfiguration<ControleDeJogos>
    {
        public MappingControleDeJogos()
        {
            ToTable("ControleDeJogos");

            //Property(p => p.JogoPlataforma)
                //.HasColumnName("JogosPlataforma");
           

            Property(p => p.Adquirir)
                 .HasColumnName("Adquirir");

            Property(p => p.Adquirir)
                 .HasColumnName("DataAdquirir");

            Property(p => p.Adquirir)
                 .HasColumnName("Troco");

            Property(p => p.Adquirir)
                 .HasColumnName("Vendo");

        }
    }
}
