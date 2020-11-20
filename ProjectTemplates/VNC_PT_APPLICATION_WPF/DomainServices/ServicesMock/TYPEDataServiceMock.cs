
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VNC_PT_APPLICATION_WPF.Domain;
using VNC.Core.DomainServices;

namespace VNC_PT_APPLICATION_WPF.DomainServices
{
    public class TYPEDataServiceMock : ITYPEDataService
    {
        public IEnumerable<TYPE> All()
        {
            //// TODO(crhodes)
            //// Load data from real database.
            //// For now just return hard coded list.
            ///
            yield return new TYPE
            {
                Id = 1,
                FieldString = "FieldString",
                FieldDouble = 2.0,
                FieldInt = 23
                
            };
            yield return new TYPE { Id = 2, FieldString = null, FieldDouble = Double.MaxValue, FieldInt = int.MaxValue };
        }

        public Task<List<TYPE>> AllAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TYPE> AllInclude(params Expression<Func<TYPE, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TYPE>> AllIncludeAsync(params Expression<Func<TYPE, object>>[] includeProperties)
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

        public IEnumerable<TYPE> FindBy(Expression<Func<TYPE, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TYPE>> FindByAsync(Expression<Func<TYPE, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TYPE FindById(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<TYPE> FindByIdAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TYPE> FindByInclude(Expression<Func<TYPE, bool>> predicate, params Expression<Func<TYPE, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TYPE>> FindByIncludeAsync(Expression<Func<TYPE, bool>> predicate, params Expression<Func<TYPE, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Insert(TYPE entity)
        {
            throw new NotImplementedException();
        }

        public Task<TYPE> InsertAsync(TYPE entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TYPE entity)
        {
            throw new NotImplementedException();
        }

        public Task<TYPE> UpdateAsync(TYPE entity)
        {
            throw new NotImplementedException();
        }

        Task IDataService<TYPE>.DeleteAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        Task IDataService<TYPE>.InsertAsync(TYPE entity)
        {
            throw new NotImplementedException();
        }

        Task IDataService<TYPE>.UpdateAsync(TYPE entity)
        {
            throw new NotImplementedException();
        }
    }
}
