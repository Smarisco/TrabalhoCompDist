using System.Data.Entity.ModelConfiguration;
using TrabalhoCompDist.Entities;

namespace Infraestrutura.Persistencia.Mapping
{
    class MappingJogador:EntityTypeConfiguration<Jogador>
    {
        public MappingJogador()
        {
            ToTable("Jogador");
        }
    }
}
