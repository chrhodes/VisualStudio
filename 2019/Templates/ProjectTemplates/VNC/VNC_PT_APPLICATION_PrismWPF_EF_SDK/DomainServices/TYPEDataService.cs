using System;
using System.Data.Entity;
using System.Threading.Tasks;

using $xxxAPPLICATIONxxx$$xxxNAMESPACExxx$.Domain;
using $xxxAPPLICATIONxxx$$xxxNAMESPACExxx$.Persistence.Data;

using VNC;
using VNC.Core.DomainServices;

namespace $xxxAPPLICATIONxxx$$xxxNAMESPACExxx$.DomainServices
{

    public class $xxxTYPExxx$DataService : GenericEFRepository<$xxxTYPExxx$, $xxxAPPLICATIONxxx$DbContext>, I$xxxTYPExxx$DataService
    {

        #region Constructors, Initialization, and Load

        public $xxxTYPExxx$DataService($xxxAPPLICATIONxxx$DbContext context)
            : base(context)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
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

        public override async Task<$xxxTYPExxx$> FindByIdAsync(int id)
        {
            Int64 startTicks = Log.DOMAINSERVICES("($xxxTYPExxx$DataService) Enter", Common.LOG_CATEGORY);

            var result = await Context.$xxxTYPExxx$sSet
                .Include(f => f.PhoneNumbers)
                .SingleAsync(f => f.Id == id);

            Log.DOMAINSERVICES("($xxxTYPExxx$DataService) Exit", Common.LOG_CATEGORY, startTicks);

            return result;
        }

        public void RemovePhoneNumber($xxxTYPExxx$PhoneNumber model)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            Context.$xxxTYPExxx$PhoneNumbersSet.Remove(model);

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }


        #endregion

        #region Protected Methods


        #endregion

        #region Private Methods


        #endregion

    }
}
