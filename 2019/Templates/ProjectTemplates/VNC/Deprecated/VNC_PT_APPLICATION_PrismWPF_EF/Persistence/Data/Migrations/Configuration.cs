using System;
using System.Data.Entity.Migrations;

using VNC;

namespace $customAPPLICATION$.Persistence.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<$customAPPLICATION$DbContext>
    {
        public Configuration()
        {
            Int64 startTicks = Log.Trace(String.Format("Enter"), Common.LOG_APPNAME);
            
            AutomaticMigrationsEnabled = true;
            
            Log.Trace(String.Format("Exit"), Common.LOG_APPNAME, startTicks);             
        }

        protected override void Seed($customAPPLICATION$DbContext context)
        {
            Int64 startTicks = Log.Trace(String.Format("Enter"), Common.LOG_APPNAME);
            
            //  This method will be called after migrating to the latest version.

            SeedInitialDatabaseTables(context);
            base.Seed(context);
            
            Log.Trace(String.Format("Exit"), Common.LOG_APPNAME, startTicks);            
        }

        void SeedInitialDatabaseTables($customAPPLICATION$DbContext context)
        {
            Int64 startTicks = Log.Trace(String.Format("Enter"), Common.LOG_APPNAME);
            
            //  Use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            
            context.$customTYPE$Set.AddOrUpdate(
                i => i.Id,
                new Domain.$customTYPE$
                {
                    Id = 1,
                    FieldString = "$customTYPE$1",
                    FieldInt = 1,
                    FieldSingle = 1.1f,
                    FieldDouble = 11.11,
                    FieldDate = new DateTime(2001, 1, 1),
                    DateCreated = DateTime.Now
                },
                new Domain.$customTYPE$
                {
                    Id = 2,
                    FieldString = "$customTYPE$2",
                    FieldInt = 2,
                    FieldSingle = 2.2f,
                    FieldDouble = 22.22,
                    FieldDate = new DateTime(2002, 2, 2),
                    DateCreated = DateTime.Now
                },                
                new Domain.$customTYPE$
                {
                    Id = 3,
                    FieldString = "$customTYPE$3",
                    FieldInt = 3,
                    FieldSingle = 3.3f,
                    FieldDouble = 33.33,
                    FieldDate = new DateTime(2003, 3, 3),
                    DateCreated = DateTime.Now
                });
                
            Log.Trace(String.Format("Exit"), Common.LOG_APPNAME, startTicks);                
        }
    }
}
