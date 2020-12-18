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
    public class $xxxITEMxxx$LookupDataService : I$xxxITEMxxx$LookupDataService
    {

        #region Constructors, Initialization, and Load

        public $xxxITEMxxx$LookupDataService(Func<$customAPPLICATION$DbContext> context)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            _contextCreator = context;

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Enums


        #endregion

        #region Structures


        #endregion

        #region Fields and Properties

        private Func<$customAPPLICATION$DbContext> _contextCreator;

        #endregion

        #region Event Handlers


        #endregion

        #region Public Methods

        public async Task<IEnumerable<LookupItem>> Get$xxxITEMxxx$LookupAsync()
        {
            Int64 startTicks = Log.DOMAINSERVICES("($xxxITEMxxx$LookupDataService) Enter", Common.LOG_APPNAME);

            IEnumerable<LookupItem> result;

            using (var ctx = _contextCreator())
            {
                result =  await ctx.$xxxITEMxxx$Set.AsNoTracking()
                  .Select(f =>
                  new LookupItem
                  {
                      Id = f.Id,
                      DisplayMember = f.Name
                  })
                  .ToListAsync();
            }

            Log.DOMAINSERVICES("($xxxITEMxxx$LookupDataService) Exit", Common.LOG_APPNAME, startTicks);

            return result;
        }

        #endregion

        #region Protected Methods


        #endregion

        #region Private Methods


        #endregion

    }
}
