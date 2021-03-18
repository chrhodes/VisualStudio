using System;
using System.Data.Entity;
using System.Threading.Tasks;

using $customAPPLICATION$.Domain;
using $customAPPLICATION$.Persistence.Data;

using VNC;
using VNC.Core.DomainServices;

namespace $customAPPLICATION$.DomainServices
{

    public class $xxxITEMxxx$DataService : GenericEFRepository<$xxxITEMxxx$, $customAPPLICATION$DbContext>, I$xxxITEMxxx$DataService
    {

        #region Constructors, Initialization, and Load

        public $xxxITEMxxx$DataService($customAPPLICATION$DbContext context)
            : base(context)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Enums


        #endregion

        #region Structures


        #endregion

        #region Fields and Properties

        
        #endregion

        #region Event Handlers


        #endregion

        #region Public Methods

        public async Task<bool> IsReferencedBy$customTYPE$Async(int id)
        {
            Int64 startTicks = Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Enter", Common.LOG_APPNAME);

            var result = await Context.$customTYPE$sSet.AsNoTracking()
                .AnyAsync(f => f.Favorite$xxxITEMxxx$Id == id);

            Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Exit", Common.LOG_APPNAME, startTicks);

            return result;
        }
        
        #endregion
        
        #region Protected Methods


        #endregion

        #region Private Methods


        #endregion
   

    }
}
