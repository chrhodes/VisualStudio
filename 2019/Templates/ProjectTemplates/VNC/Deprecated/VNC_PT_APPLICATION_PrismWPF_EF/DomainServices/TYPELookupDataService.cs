using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

using $customAPPLICATION$.Persistence.Data;

using VNC;

using VNC.Core.DomainServices;

namespace $customAPPLICATION$.DomainServices
{
    public class $customTYPE$LookupDataService : I$customTYPE$LookupDataService
    {
        private Func<$customAPPLICATION$DbContext> _contextCreator;

        public $customTYPE$LookupDataService(Func<$customAPPLICATION$DbContext> context)
        {
            Int64 startTicks = Log.CONSTRUCTOR(String.Format("Enter"), Common.LOG_APPNAME);
                        
            _contextCreator = context;
            
            Log.CONSTRUCTOR(String.Format("Exit"), Common.LOG_APPNAME, startTicks);
        }

        public async Task<IEnumerable<LookupItem>> Get$customTYPE$LookupAsync()
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
                        
            using (var ctx = _contextCreator())
            {
                return await ctx.$customTYPE$Set.AsNoTracking()
                  .Select(f =>
                  new LookupItem
                  {
                      Id = f.Id,
                      DisplayMember = f.FieldString
                  })
                  .ToListAsync();
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);
        }
    }
}
