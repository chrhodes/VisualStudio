using System.Data.Entity.Migrations;

namespace VNC_PT_APPLICATION.Persistence.LookupData.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<VNC_PT_APPLICATION.Persistence.LookupData.VNC_PT_APPLICATIONLookupsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VNC_PT_APPLICATION.Persistence.LookupData.VNC_PT_APPLICATIONLookupsDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
