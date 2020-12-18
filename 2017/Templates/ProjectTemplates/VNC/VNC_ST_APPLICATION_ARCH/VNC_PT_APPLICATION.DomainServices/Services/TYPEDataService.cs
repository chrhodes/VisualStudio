using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using $customAPPLICATION$.Persistence.Data;
using $customAPPLICATION$.Domain;

using VNC.Core.Domain;

namespace $safeprojectname$
{
    // TODO(crhodes)
    // Think we are almost to making this Generic.  But then what is difference 
    // between this and Generic Repository in VNC.Core.
    // Carefully trace through the code path.

    public class $customTYPE$DataService : I$customTYPE$DataService
    {
        private Func<$customAPPLICATION$DbContext> _contextCreator;

        private ConnectedRepository<$customTYPE$> _repository;

        #region Constructors

        public $customTYPE$DataService(Func<$customAPPLICATION$DbContext> context)
        {
            _contextCreator = context;
        }

        #endregion Constructors

        #region Public Methods

        #region All

        public IEnumerable<$customTYPE$> All()
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return _repository.All();
            }
        }

        public async Task<List<$customTYPE$>> AllAsync()
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return await _repository.AllAsync();
            }
        }

        public IEnumerable<$customTYPE$> AllInclude(
            params Expression<Func<$customTYPE$, object>>[] includeProperties)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return _repository.AllInclude(includeProperties);
            }
        }

        public async Task<IEnumerable<$customTYPE$>> AllIncludeAsync(
            params Expression<Func<$customTYPE$, object>>[] includeProperties)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return await _repository.AllIncludeAsync(includeProperties);
            }
        }

        #endregion All

        #region Find

        public $customTYPE$ FindById(int entityId)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return _repository.FindById(entityId);
            }
        }

        public async Task<$customTYPE$> FindByIdAsync(int entityId)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return await _repository.FindByIdAsync(entityId);
            }
        }

        public IEnumerable<$customTYPE$> FindBy(
            Expression<Func<$customTYPE$, bool>> predicate)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return _repository.FindBy(predicate);
            }
        }

        public async Task<IEnumerable<$customTYPE$>> FindByAsync(
            Expression<Func<$customTYPE$, bool>> predicate)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return await _repository.FindByAsync(predicate);
            }
        }

        public IEnumerable<$customTYPE$> FindByInclude(
            Expression<Func<$customTYPE$, bool>> predicate,
            params Expression<Func<$customTYPE$, object>>[] includeProperties)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return _repository.FindByInclude(predicate, includeProperties);
            }
        }

        public async Task<IEnumerable<$customTYPE$>> FindByIncludeAsync(
            Expression<Func<$customTYPE$, bool>> predicate,
            params Expression<Func<$customTYPE$, object>>[] includeProperties)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                return await _repository.FindByIncludeAsync(predicate, includeProperties);
            }
        }

        // TODO(crhodes)
        // Decide if we need FindByKey

        #endregion Find

        #region Insert

        public void Insert($customTYPE$ entity)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                _repository.Insert(entity);
            }
        }

        public async Task InsertAsync($customTYPE$ entity)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                await _repository.InsertAsync(entity);
            }
        }

        #endregion Insert

        #region Update

        public void Update($customTYPE$ entity)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                _repository.Update(entity);
            }
        }

        public async Task UpdateAsync($customTYPE$ entity)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                await _repository.UpdateAsync(entity);
            }
        }

        #endregion Update

        #region Delete

        public void Delete(int entityId)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                _repository.Delete(entityId);
            }
        }

        public async Task DeleteAsync(int entityId)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$customTYPE$>(context);
                await _repository.DeleteAsync(entityId);
            }
        }

        #endregion Delete

        #endregion

    }
}
