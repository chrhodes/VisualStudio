using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

using VNC_PT_APPLICATION_WPF.Persistence.Data;
using VNC_PT_APPLICATION_WPF.Domain;

using VNC.Core.Domain;

namespace VNC_PT_APPLICATION_WPF.DomainServices
{
    public class TYPELookupDataService : ITYPELookupDataService
    {
        private Func<VNC_PT_APPLICATION_WPFDbContext> _contextCreator;

        public TYPELookupDataService(Func<VNC_PT_APPLICATION_WPFDbContext> context)
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
