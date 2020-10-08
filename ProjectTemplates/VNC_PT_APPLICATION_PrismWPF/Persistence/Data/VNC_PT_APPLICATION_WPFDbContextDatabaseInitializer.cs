using System;
using System.Data.Entity;

namespace VNC_PT_APPLICATION_PrismWPF.Persistence.Data
{
    public class VNC_PT_APPLICATION_WPFDbContextDatabaseInitializer : CreateDatabaseIfNotExists<VNC_PT_APPLICATION_WPFDbContext>
    {
        protected override void Seed(VNC_PT_APPLICATION_WPFDbContext context)
        {
            Console.WriteLine("Seed(VNC_PT_APPLICATION_WPFDbContext)");
            base.Seed(context);
        }
    }
}
