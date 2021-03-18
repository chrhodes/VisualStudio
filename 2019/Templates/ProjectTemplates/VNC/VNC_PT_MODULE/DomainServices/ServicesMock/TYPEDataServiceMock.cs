using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using $xxxAPPLICATIONxxx$$xxxNAMESPACExxx$.Domain;

using VNC;
using VNC.Core.DomainServices;

namespace $xxxAPPLICATIONxxx$$xxxNAMESPACExxx$.DomainServices
{
    public class $xxxTYPExxx$DataServiceMock : I$xxxTYPExxx$DataService
    {
        public IEnumerable<$xxxTYPExxx$> All()
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            // TODO(crhodes)
            // Load data from real database.
            // For now just return hard coded list.

            yield return new $xxxTYPExxx$
            {
                Id = 1,
                FieldString = "FieldString",
                FieldDouble = 2.0,
                FieldInt = 23

            };

            yield return new $xxxTYPExxx$
            {
                Id = 2,
                FieldString = null,
                FieldDouble = Double.MaxValue,
                FieldInt = int.MaxValue
            };

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public Task<List<$xxxTYPExxx$>> AllAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<$xxxTYPExxx$> AllInclude(params Expression<Func<$xxxTYPExxx$, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<$xxxTYPExxx$>> AllIncludeAsync(params Expression<Func<$xxxTYPExxx$, object>>[] includeProperties)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            throw new NotImplementedException();

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public IEnumerable<$xxxTYPExxx$> FindBy(Expression<Func<$xxxTYPExxx$, bool>> predicate)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            throw new NotImplementedException();

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public Task<IEnumerable<$xxxTYPExxx$>> FindByAsync(Expression<Func<$xxxTYPExxx$, bool>> predicate)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            throw new NotImplementedException();

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public $xxxTYPExxx$ FindById(int entityId)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            throw new NotImplementedException();

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public Task<$xxxTYPExxx$> FindByIdAsync(int entityId)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            throw new NotImplementedException();

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public IEnumerable<$xxxTYPExxx$> FindByInclude(Expression<Func<$xxxTYPExxx$, bool>> predicate, params Expression<Func<$xxxTYPExxx$, object>>[] includeProperties)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            throw new NotImplementedException();

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public Task<IEnumerable<$xxxTYPExxx$>> FindByIncludeAsync(Expression<Func<$xxxTYPExxx$, bool>> predicate, params Expression<Func<$xxxTYPExxx$, object>>[] includeProperties)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            throw new NotImplementedException();

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public bool HasChanges()
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            throw new NotImplementedException();

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void Add($xxxTYPExxx$ entity)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            throw new NotImplementedException();

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void Remove($xxxTYPExxx$ entity)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            throw new NotImplementedException();

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void RemovePhoneNumber($xxxTYPExxx$PhoneNumber model)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            throw new NotImplementedException();

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void Update()
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);
                      
            throw new NotImplementedException();
            
            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);            
        }
        
        public Task<$xxxTYPExxx$> UpdateAsync($xxxTYPExxx$ entity)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            throw new NotImplementedException();

            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public Task UpdateAsync()
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_CATEGORY);

            throw new NotImplementedException();
            
            Log.DOMAINSERVICES("Exit", Common.LOG_CATEGORY, startTicks);            
        }
    }
}
