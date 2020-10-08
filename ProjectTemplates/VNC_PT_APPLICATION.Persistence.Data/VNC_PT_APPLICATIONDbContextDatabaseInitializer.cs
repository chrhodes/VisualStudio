using System;
using System.Data.Entity;

namespace VNC_PT_APPLICATION.Persistence.Data
{
    public class VNC_PT_APPLICATIONDbContextDatabaseInitializer : CreateDatabaseIfNotExists<VNC_PT_APPLICATIONDbContext>
    {
        protected override void Seed(VNC_PT_APPLICATIONDbContext context)
        {
            Console.WriteLine("Seed(VNC_PT_APPLICATIONDbContext)");
            base.Seed(context);
        }
    }
}
