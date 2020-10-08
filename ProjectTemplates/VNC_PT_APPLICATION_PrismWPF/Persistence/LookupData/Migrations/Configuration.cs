using System.Data.Entity.Migrations;

namespace VNC_PT_APPLICATION_PrismWPF.Persistence.LookupData.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<VNC_PT_APPLICATION_PrismWPF.Persistence.LookupData.VNC_PT_APPLICATION_WPFLookupsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VNC_PT_APPLICATION_PrismWPF.Persistence.LookupData.VNC_PT_APPLICATION_WPFLookupsDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
