﻿using System;
using System.Data.Entity;

using VNC;

namespace $customAPPLICATION$.Persistence.Data
{
    public class $customAPPLICATION$DbContextDatabaseInitializer : CreateDatabaseIfNotExists<$customAPPLICATION$DbContext>
    {
        protected override void Seed($customAPPLICATION$DbContext context)
        {
            Int64 startTicks = Log.PERSISTENCE("Enter", Common.LOG_APPNAME);
            
            base.Seed(context);
            
            Log.PERSISTENCE("Exit", Common.LOG_APPNAME, startTicks);             
        }
    }
}
