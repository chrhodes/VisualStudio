using System;
using System.Data.Entity;

namespace APPLICATION.Persistence.Data
{
    public class APPLICATIONDbContextDatabaseInitializer : CreateDatabaseIfNotExists<APPLICATIONDbContext>
    {
        protected override void Seed(APPLICATIONDbContext context)
        {
            Console.WriteLine("Seed(APPLICATIONDbContext)");
            base.Seed(context);
        }
    }
}
