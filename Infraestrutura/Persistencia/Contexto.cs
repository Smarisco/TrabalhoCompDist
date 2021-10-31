using System.Data.Entity;
using TrabalhoCompDist.Entities;


namespace Infraestrutura.Persistencia
{
    public class Contexto: DbContext
    {
        public Contexto():base("ConnectingSting")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

        }
        public IDbSet<Jogador> jogadores { get; set; }
    }
}
