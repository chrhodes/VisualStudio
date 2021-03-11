using System;
using System.Data.Entity;
using System.Threading.Tasks;

using $xxxAPPLICATIONxxx$.Domain;
using $xxxAPPLICATIONxxx$.Persistence.Data;

using VNC;
using VNC.Core.DomainServices;

namespace $xxxAPPLICATIONxxx$.DomainServices
{

    public class $xxxITEMxxx$DataService : GenericEFRepository<$xxxITEMxxx$, $xxxAPPLICATIONxxx$DbContext>, I$xxxITEMxxx$DataService
    {

        #region Constructors, Initialization, and Load

        public $xxxITEMxxx$DataService($xxxAPPLICATIONxxx$DbContext context)
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

        public async Task<bool> IsReferencedBy$xxxTYPExxx$Async(int id)
        {
            Int64 startTicks = Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Enter", Common.LOG_APPNAME);

            var result = await Context.$xxxTYPExxx$sSet.AsNoTracking()
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
