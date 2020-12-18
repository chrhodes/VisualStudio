using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

using $customAPPLICATION$.Persistence.Data;
using $customAPPLICATION$.Domain;

using VNC.Core.Domain;

namespace $safeprojectname$
{
    public class $customTYPE$LookupDataService : I$customTYPE$LookupDataService
    {
        private Func<$customAPPLICATION$DbContext> _contextCreator;

        public $customTYPE$LookupDataService(Func<$customAPPLICATION$DbContext> context)
        {
            _contextCreator = context;
        }

        public async Task<IEnumerable<LookupItem>> Get$customTYPE$LookupAsync()
        {
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
        }
    }
}
