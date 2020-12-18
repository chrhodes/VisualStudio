using System.Data.Entity.Migrations;

namespace $safeprojectname$.Persistence.LookupData.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<$safeprojectname$.Persistence.LookupData.APPLICATIONLookupsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed($safeprojectname$.Persistence.LookupData.APPLICATIONLookupsDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
