using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using $safeprojectname$.Persistence.Data;
using $safeprojectname$.Domain;

using VNC.Core.Domain;

namespace $safeprojectname$.DomainServices
{
    // TODO(crhodes)
    // Think we are almost to making this Generic.  But then what is difference 
    // between this and Generic Repository in VNC.Core.
    // Carefully trace through the code path.

    public class TYPEDataService : ITYPEDataService
    {
        private Func<VNC_PT_APPLICATION_WPFDbContext> _contextCreator;

        private ConnectedRepository<TYPE> _repository;

        #region Constructors

        public TYPEDataService(Func<VNC_PT_APPLICATION_WPFDbContext> context)
        {
            _contextCreator = context;
        }

        #endregion Constructors

        #region Public Methods

        #region All

        public IEnumerable<TYPE> All()
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                return _repository.All();
            }
        }

        public async Task<List<TYPE>> AllAsync()
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                return await _repository.AllAsync();
            }
        }

        public IEnumerable<TYPE> AllInclude(
            params Expression<Func<TYPE, object>>[] includeProperties)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                return _repository.AllInclude(includeProperties);
            }
        }

        public async Task<IEnumerable<TYPE>> AllIncludeAsync(
            params Expression<Func<TYPE, object>>[] includeProperties)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                return await _repository.AllIncludeAsync(includeProperties);
            }
        }

        #endregion All

        #region Find

        public TYPE FindById(int entityId)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                return _repository.FindById(entityId);
            }
        }

        public async Task<TYPE> FindByIdAsync(int entityId)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                return await _repository.FindByIdAsync(entityId);
            }
        }

        public IEnumerable<TYPE> FindBy(
            Expression<Func<TYPE, bool>> predicate)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                return _repository.FindBy(predicate);
            }
        }

        public async Task<IEnumerable<TYPE>> FindByAsync(
            Expression<Func<TYPE, bool>> predicate)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                return await _repository.FindByAsync(predicate);
            }
        }

        public IEnumerable<TYPE> FindByInclude(
            Expression<Func<TYPE, bool>> predicate,
            params Expression<Func<TYPE, object>>[] includeProperties)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                return _repository.FindByInclude(predicate, includeProperties);
            }
        }

        public async Task<IEnumerable<TYPE>> FindByIncludeAsync(
            Expression<Func<TYPE, bool>> predicate,
            params Expression<Func<TYPE, object>>[] includeProperties)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                return await _repository.FindByIncludeAsync(predicate, includeProperties);
            }
        }

        // TODO(crhodes)
        // Decide if we need FindByKey

        #endregion Find

        #region Insert

        public void Insert(TYPE entity)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                _repository.Insert(entity);
            }
        }

        public async Task InsertAsync(TYPE entity)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                await _repository.InsertAsync(entity);
            }
        }

        #endregion Insert

        #region Update

        public void Update(TYPE entity)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                _repository.Update(entity);
            }
        }

        public async Task UpdateAsync(TYPE entity)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                await _repository.UpdateAsync(entity);
            }
        }

        #endregion Update

        #region Delete

        public void Delete(int entityId)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                _repository.Delete(entityId);
            }
        }

        public async Task DeleteAsync(int entityId)
        {
            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<TYPE>(context);
                await _repository.DeleteAsync(entityId);
            }
        }

        #endregion Delete

        #endregion

    }
}
