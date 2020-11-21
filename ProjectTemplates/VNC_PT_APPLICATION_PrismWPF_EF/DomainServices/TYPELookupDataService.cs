using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

using APPLICATION.Persistence.Data;
//using APPLICATION.Persistence.LookupData;

using VNC.Core.DomainServices;

namespace APPLICATION.DomainServices
{
    public class LookupDataService : ITYPELookupDataService
    {
        private Func<APPLICATIONDbContext> _contextCreator;

        public LookupDataService(Func<APPLICATIONDbContext> context)
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
