using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using $customAPPLICATION$.Domain;
using $customAPPLICATION$.Persistence.Data;

using VNC;
using VNC.Core.DomainServices;

namespace $customAPPLICATION$.DomainServices
{
    // NOTE(crhodes)
    // This creates a new context each time.  How would HasChanges work?

    public class $customTYPE$DataService : I$customTYPE$DataService
    {
        private Func<$customAPPLICATION$DbContext> _contextCreator;

        private ConnectedRepository<$customTYPE$> _repository;

        #region Constructors

        public $customTYPE$DataService(Func<$customAPPLICATION$DbContext> context)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);
                        
            _contextCreator = context;
            
            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);            
        }

        #endregion Constructors

        #region Public Methods

        #region All

        public IEnumerable<$customTYPE$> All()
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return _repository.All();
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);
        }

        public async Task<List<$customTYPE$>> AllAsync()
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return await _repository.AllAsync();
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);
        }

        public IEnumerable<$customTYPE$> AllInclude(
            params Expression<Func<$customTYPE$, object>>[] includeProperties)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return _repository.AllInclude(includeProperties);
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);         
        }

        public async Task<IEnumerable<$customTYPE$>> AllIncludeAsync(
            params Expression<Func<$customTYPE$, object>>[] includeProperties)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return await _repository.AllIncludeAsync(includeProperties);
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);         
        }

        #endregion All

        #region Find

        public $customTYPE$ FindById(int entityId)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return _repository.FindById(entityId);
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);          
        }

        public async Task<$customTYPE$> FindByIdAsync(int entityId)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return await _repository.FindByIdAsync(entityId);
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);       
        }

        public IEnumerable<$customTYPE$> FindBy(
            Expression<Func<$customTYPE$, bool>> predicate)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return _repository.FindBy(predicate);
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);        
        }

        public async Task<IEnumerable<$customTYPE$>> FindByAsync(
            Expression<Func<$customTYPE$, bool>> predicate)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return await _repository.FindByAsync(predicate);
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);       
        }

        public IEnumerable<$customTYPE$> FindByInclude(
            Expression<Func<$customTYPE$, bool>> predicate,
            params Expression<Func<$customTYPE$, object>>[] includeProperties)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return _repository.FindByInclude(predicate, includeProperties);
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);         
        }

        public async Task<IEnumerable<$customTYPE$>> FindByIncludeAsync(
            Expression<Func<$customTYPE$, bool>> predicate,
            params Expression<Func<$customTYPE$, object>>[] includeProperties)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return await _repository.FindByIncludeAsync(predicate, includeProperties);
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);         
        }

        // TODO(crhodes)
        // Decide if we need FindByKey

        #endregion Find

        #region Insert

        public void Insert($customTYPE$ entity)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                _repository.Insert(entity);
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);          
        }

        public async Task InsertAsync($customTYPE$ entity)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                await _repository.InsertAsync(entity);
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);         
        }

        #endregion Insert

        #region Update

        public void Update($customTYPE$ entity)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                _repository.Update(entity);
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);         
        }

        public async Task UpdateAsync()
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                await _repository.UpdateAsync();
            }

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);
        }

        public async Task UpdateAsync($customTYPE$ entity)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);

                if (entity.Id <= 0)
                {
                    await _repository.InsertAsync(entity);
                }
                else
                {
                    await _repository.UpdateAsync(entity);
                }
            }

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion Update

        #region Delete

        public void Delete(int entityId)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                _repository.Delete(entityId);
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);        
        }

        public async Task DeleteAsync(int entityId)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);
            
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                await _repository.DeleteAsync(entityId);
            }
            
            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);      
        }

        public bool HasChanges()
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            // TODO(crhodes)
            // Hum.  How to determine if something has changed that can drive the UI logic.
            // This wont' work as we are creating a brand new context.

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                var result = _repository.HasChanges();
                return result;
            }

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

        }

        #endregion Delete

        #endregion

    }
}
