using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

using VNC_PT_APPLICATION.Persistence.Data;
using VNC_PT_APPLICATION.Domain;

using VNC.Core.Domain;

namespace VNC_PT_APPLICATION.DomainServices
{
    public class TYPELookupDataService : ITYPELookupDataService
    {
        private Func<VNC_PT_APPLICATIONDbContext> _contextCreator;

        public TYPELookupDataService(Func<VNC_PT_APPLICATIONDbContext> context)
        {
            _contextCreator = context;
        }

        public async Task<IEnumerable<LookupItem>> GetTYPELookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.TYPESet.AsNoTracking()
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
