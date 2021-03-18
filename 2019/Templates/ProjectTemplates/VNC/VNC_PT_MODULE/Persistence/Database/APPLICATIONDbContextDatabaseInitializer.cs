using System;
using System.Data.Entity;

using VNC;

namespace $xxxAPPLICATIONxxx$$xxxNAMESPACExxx$.Persistence.Data
{
    public class $xxxAPPLICATIONxxx$DbContextDatabaseInitializer : CreateDatabaseIfNotExists<$xxxAPPLICATIONxxx$DbContext>
    {
        protected override void Seed($xxxAPPLICATIONxxx$DbContext context)
        {
            Int64 startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
            
            base.Seed(context);
            
            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);             
        }
    }
}
