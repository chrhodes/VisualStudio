using System;
using System.Data.Entity.Migrations;

using VNC;

namespace $xxxAPPLICATIONxxx$$xxxNAMESPACExxx$.Persistence.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<$xxxAPPLICATIONxxx$DbContext>
    {
        public Configuration()
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            AutomaticMigrationsEnabled = true;

            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        protected override void Seed($xxxAPPLICATIONxxx$DbContext context)
        {
            Int64 startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);

            //  This method will be called after migrating to the latest version.

            SeedInitialDatabaseTables(context);
            base.Seed(context);

            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
        }

        void SeedInitialDatabaseTables($xxxAPPLICATIONxxx$DbContext context)
        {
            Int64 startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);

            //  Use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.$xxxTYPExxx$sSet.AddOrUpdate(
                i => i.Id,
                new Domain.$xxxTYPExxx$
                {
                    Id = 1,
                    FieldString = "$xxxTYPExxx$1",
                    FieldInt = 1,
                    FieldSingle = 1.1f,
                    FieldDouble = 11.11,
                    FieldDate = new DateTime(2001, 1, 1),
                    DateCreated = DateTime.Now
                },
                new Domain.$xxxTYPExxx$
                {
                    Id = 2,
                    FieldString = "$xxxTYPExxx$2",
                    FieldInt = 2,
                    FieldSingle = 2.2f,
                    FieldDouble = 22.22,
                    FieldDate = new DateTime(2002, 2, 2),
                    DateCreated = DateTime.Now
                },
                new Domain.$xxxTYPExxx$
                {
                    Id = 3,
                    FieldString = "$xxxTYPExxx$3",
                    FieldInt = 3,
                    FieldSingle = 3.3f,
                    FieldDouble = 33.33,
                    FieldDate = new DateTime(2003, 3, 3),
                    DateCreated = DateTime.Now
                });

            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}
