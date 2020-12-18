
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using $customAPPLICATION$.Domain;
using VNC.Core.Domain;

namespace $safeprojectname$
{
    public class $customTYPE$DataServiceMock : I$customTYPE$DataService
    {
        public IEnumerable<$customTYPE$> All()
        {
            //// TODO(crhodes)
            //// Load data from real database.
            //// For now just return hard coded list.
            ///
            yield return new $customTYPE$
            {
                Id = 1,
                FieldString = "FieldString",
                FieldDouble = 2.0,
                FieldInt = 23
                
            };
            yield return new $customTYPE$ { Id = 2, FieldString = null, FieldDouble = Double.MaxValue, FieldInt = int.MaxValue };
        }

        public Task<List<$customTYPE$>> AllAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<$customTYPE$> AllInclude(params Expression<Func<$customTYPE$, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<$customTYPE$>> AllIncludeAsync(params Expression<Func<$customTYPE$, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<$customTYPE$> FindBy(Expression<Func<$customTYPE$, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<$customTYPE$>> FindByAsync(Expression<Func<$customTYPE$, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public $customTYPE$ FindById(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<$customTYPE$> FindByIdAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<$customTYPE$> FindByInclude(Expression<Func<$customTYPE$, bool>> predicate, params Expression<Func<$customTYPE$, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<$customTYPE$>> FindByIncludeAsync(Expression<Func<$customTYPE$, bool>> predicate, params Expression<Func<$customTYPE$, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Insert($customTYPE$ entity)
        {
            throw new NotImplementedException();
        }

        public Task<$customTYPE$> InsertAsync($customTYPE$ entity)
        {
            throw new NotImplementedException();
        }

        public void Update($customTYPE$ entity)
        {
            throw new NotImplementedException();
        }

        public Task<$customTYPE$> UpdateAsync($customTYPE$ entity)
        {
            throw new NotImplementedException();
        }

        Task IDataService<$customTYPE$>.DeleteAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        Task IDataService<$customTYPE$>.InsertAsync($customTYPE$ entity)
        {
            throw new NotImplementedException();
        }

        Task IDataService<$customTYPE$>.UpdateAsync($customTYPE$ entity)
        {
            throw new NotImplementedException();
        }
    }
}
