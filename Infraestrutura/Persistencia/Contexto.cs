using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TrabalhoCompDist.Entities;


namespace Infraestrutura.Persistencia
{
    public class Contexto : DbContext
    {
        public Contexto() : base("ConnectingSting")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

        }
        public IDbSet<Jogador> Jogadores { get; set; }
        public IDbSet<Plataforma> Plataformas { get; set; }
        public IDbSet<Jogos> Jogos { get; set; }
        public IDbSet<ControleDeJogos> ControleDeJogos { get; set; }
        public IDbSet<JogoDaPlataforma> JogosDaPlataforma { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //setar com schema
            //modelBuilder.HasDefaultSchema(" ");
            //Remove43 a pluralização dos nomes na tabela
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Remove exclusão em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Setar para usar varchar ou invés de nvarchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            base.OnModelCreating(modelBuilder);
        }
    }
}
