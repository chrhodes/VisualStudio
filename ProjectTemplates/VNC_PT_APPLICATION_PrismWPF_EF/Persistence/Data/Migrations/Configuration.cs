using System;
using System.Data.Entity.Migrations;

namespace APPLICATION.Persistence.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<APPLICATIONDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(APPLICATIONDbContext context)
        {
            Console.WriteLine("Seed()");
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // This Seeds Address, Customer, and Material

            SeedInitialDatabaseTables(context);
            base.Seed(context);
        }

        void SeedInitialDatabaseTables(APPLICATIONDbContext context)
        {
            context.TYPESet.AddOrUpdate(
                i => i.Id,
                new Domain.TYPE
                {
                    Id = 1,
                    FieldString = "String1",
                    FieldInt = 41,
                    FieldDouble = 41.41
                },
                new Domain.TYPE
                {
                    Id = 2,
                    FieldString = "String2",
                    FieldInt = 42,
                    FieldDouble = 42.42
                });
        }


    }
}
