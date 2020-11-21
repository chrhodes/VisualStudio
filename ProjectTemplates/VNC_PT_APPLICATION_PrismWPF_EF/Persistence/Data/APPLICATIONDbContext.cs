﻿using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

using VNC.Core.DomainServices;

using APPLICATION.Domain;

namespace APPLICATION.Persistence.Data
{
    public class APPLICATIONDbContext : DbContext, IAPPLICATIONDbContext
    {
        public DbSet<TYPE> TYPESet { get; set; }

        // Name of connection string

        public DbSet<TYPE> TYPESet { get; set; }

        // Name of connection string in Config

        public APPLICATIONDbContext() : base("APPLICATION_DB")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<APPLICATIONDbContext, Configuration>());

            // There are four database initialization strategies

            // 1. CreateDatabaseIfNotExists (default)

            // Database.SetInitializer<APPLICATIONDbContext>(new CreateDatabaseIfNotExists<APPLICATIONDbContext>());

            // 2. DropCreateDatabaseIfModelChanges

            // Database.SetInitializer<APPLICATIONDbContext>(new DropCreateDatabaseIfModelChanges<APPLICATIONDbContext>());

            Database.SetInitializer<APPLICATIONDbContext>(
                new DropCreateDatabaseIfModelChanges<APPLICATIONDbContext>());

            // 3. DropCreateDatabaseAlways

            // Database.SetInitializer<APPLICATIONDbContext>(new DropCreateDatabaseAlways<APPLICATIONDbContext>());

            // 4. Custom DB Initializer

            //Database.SetInitializer<APPLICATIONDbContext>(new APPLICATIONDbContextDatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            try
            {
                // TODO(crhodes)
                // This gives us too many types including the embedded ServiceType and PoolConditionReport
                // Need some way of filtering them out, otherwise have to put pointless IsDirty field in them.

                modelBuilder.Types()
                    .Configure(c => c.Ignore("IsDirty"));

            }
            catch (InvalidOperationException ex)
            {
                // Ignore
            }

            base.OnModelCreating(modelBuilder);

            // Do not pluralize table names

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.HasDefaultSchema("Domain");

            // Ignore any IsDirty property on any types pulled into model.



            // Fluent API approach to constraints
            // Alternative is to apply attributes to Model Class

            //modelBuilder.Entity<Friend>()
            //    .Property(f => f.FirstName)
            //    .IsRequired()
            //    .HasMaxLength(50);

            // Could also have a general purpose approach. See class infra.

            //modelBuilder.Configurations.Add(new FriendConfiguration());

            // Alternatively can use DataAnnotations on model class.

        }

        public override int SaveChanges()
        {
            try
            {
                // Override SaveChanges so EF will enforce use of IModificationHistory changes.

                var hist = this.ChangeTracker.Entries();

                foreach (var item in hist)
                {
                    var isImod = item is IModificationHistory;
                    int i = 0;
                }

                foreach (var history in this.ChangeTracker.Entries()
                  .Where(e => e.Entity is IModificationHistory
                    && (e.State == EntityState.Added || e.State == EntityState.Modified))
                   .Select(e => e.Entity as IModificationHistory)
                  )
                {
                    history.DateModified = DateTime.Now;

                    // Use DateCreated DateTime.MinValue as new flag

                    var dt = DateTime.MinValue;
                    var dt2 = SqlDateTime.MinValue;
                    var hdc = history.DateCreated;

                    //if (history.DateCreated == DateTime.MinValue)
                    //{      
                    //    history.DateCreated = DateTime.Now;
                    //}

                    if (history.DateCreated == null)
                    {
                        history.DateCreated = DateTime.Now;
                    }
                }

                // Save changes to database.

                int result = base.SaveChanges();

                // Reset the IsDirty flag on any entities implementing INotificationHistory

                foreach (var history in this.ChangeTracker.Entries()
                                              .Where(e => e.Entity is IModificationHistory)
                                              .Select(e => e.Entity as IModificationHistory))
                {
                    history.IsDirty = false;
                }

                return result;
                //return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Display some details on errors

                var sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), ex
                    ); // Add the original exception as the innerException
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        //public class AddressConfiguration : EntityTypeConfiguration<Address>
        //{

        //    public AddressConfiguration()
        //    {
        //        //Property(f => f.FirstName)
        //        //    .IsRequired()
        //        //    .HasMaxLength(50);
        //    }
        //}


    }
}
