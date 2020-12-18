﻿using System;
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

    public class $xxxITEMxxx$DataService : I$xxxITEMxxx$DataService
    {

        #region Constructors, Initialization, and Load

        public $xxxITEMxxx$DataService(Func<$customAPPLICATION$DbContext> context)
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

        private ConnectedRepository<$xxxITEMxxx$> _repository;
        
        #endregion

        #region Event Handlers


        #endregion

        #region Public Methods

        #region All

        public IEnumerable<$xxxITEMxxx$> All()
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);

                Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

                return _repository.All();
            }
        }

        public async Task<List<$xxxITEMxxx$>> AllAsync()
        {
            Int64 startTicks = Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);

                Log.DOMAINSERVICES("($xxxITEMxxx$DataService)Exit", Common.LOG_APPNAME, startTicks);

                return await _repository.AllAsync();
            }
        }

        public IEnumerable<$xxxITEMxxx$> AllInclude(
            params Expression<Func<$xxxITEMxxx$, object>>[] includeProperties)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);

                Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

                return _repository.AllInclude(includeProperties);
            }
        }

        public async Task<IEnumerable<$xxxITEMxxx$>> AllIncludeAsync(
            params Expression<Func<$xxxITEMxxx$, object>>[] includeProperties)
        {
            Int64 startTicks = Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);

                Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Exit", Common.LOG_APPNAME, startTicks);

                return await _repository.AllIncludeAsync(includeProperties);
            }
        }

        #endregion All

        #region Find

        public $xxxITEMxxx$ FindById(int entityId)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);

                Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

                return _repository.FindById(entityId);
            }
        }

        public async Task<$xxxITEMxxx$> FindByIdAsync(int entityId)
        {
             Int64 startTicks = Log.DOMAINSERVICES($"(($xxxITEMxxx$DataService)) Enter entityId:({entityId})", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);

                Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Exit", Common.LOG_APPNAME, startTicks);

                return await _repository.FindByIdAsync(entityId);
            }
        }

        public IEnumerable<$xxxITEMxxx$> FindBy(
            Expression<Func<$xxxITEMxxx$, bool>> predicate)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);

                Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

                return _repository.FindBy(predicate);
            }
        }

        public async Task<IEnumerable<$xxxITEMxxx$>> FindByAsync(
            Expression<Func<$xxxITEMxxx$, bool>> predicate)
        {
            Int64 startTicks = Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);

                Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Exit", Common.LOG_APPNAME, startTicks);

                return await _repository.FindByAsync(predicate);
            }
        }

        public IEnumerable<$xxxITEMxxx$> FindByInclude(
            Expression<Func<$xxxITEMxxx$, bool>> predicate,
            params Expression<Func<$xxxITEMxxx$, object>>[] includeProperties)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);

                Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

                return _repository.FindByInclude(predicate, includeProperties);
            }
        }

        public async Task<IEnumerable<$xxxITEMxxx$>> FindByIncludeAsync(
            Expression<Func<$xxxITEMxxx$, bool>> predicate,
            params Expression<Func<$xxxITEMxxx$, object>>[] includeProperties)
        {
            Int64 startTicks = Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);

                Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Exit", Common.LOG_APPNAME, startTicks);

                return await _repository.FindByIncludeAsync(predicate, includeProperties);
            }
        }

        // TODO(crhodes)
        // Decide if we need FindByKey

        #endregion Find

        #region Insert

        public void Insert($xxxITEMxxx$ entity)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);
                _repository.Insert(entity);
            }

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);
        }

        public async Task InsertAsync($xxxITEMxxx$ entity)
        {
            Int64 startTicks = Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);
                await _repository.InsertAsync(entity);
            }

            Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion Insert

        #region Update

        public void Update($xxxITEMxxx$ entity)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);
                _repository.Update(entity);
            }

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);
        }

        public async Task UpdateAsync()
        {
            Int64 startTicks = Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);
                await _repository.UpdateAsync();
            }

            Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Exit", Common.LOG_APPNAME, startTicks);
        }

        public async Task UpdateAsync($xxxITEMxxx$ entity)
        {
            Int64 startTicks = Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);

                if (entity.Id <= 0)
                {
                    await _repository.InsertAsync(entity);
                }
                else
                {
                    await _repository.UpdateAsync(entity);
                }
            }

            Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion Update

        #region Delete

        public void Delete(int entityId)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);
                _repository.Delete(entityId);
            }

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);
        }

        public async Task DeleteAsync(int entityId)
        {
            Int64 startTicks = Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Enter", Common.LOG_APPNAME);

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);
                await _repository.DeleteAsync(entityId);
            }

            Log.DOMAINSERVICES("($xxxITEMxxx$DataService) Exit", Common.LOG_APPNAME, startTicks);
        }

        public bool HasChanges()
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            // TODO(crhodes)
            // Hum.  How to determine if something has changed that can drive the UI logic.
            // This wont' work as we are creating a brand new context.

            using (var context = _contextCreator())
            {
                _repository = new ConnectedRepository<$xxxITEMxxx$>(context);
                var result = _repository.HasChanges();

                Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

                return result;
            }
        }

        #endregion Delete

        #endregion
        
        #region Protected Methods


        #endregion

        #region Private Methods


        #endregion
   

    }
}
