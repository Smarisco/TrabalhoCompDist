namespace Infra.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configurations : DbMigrationsConfiguration<Infra.Contexto>
    {
        public Configurations()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Infra.Contexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
