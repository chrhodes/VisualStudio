using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using $safeprojectname$.Domain.Lookups;

namespace $safeprojectname$.Persistence.LookupData
{
    public class APPLICATIONLookupsDbContext : DbContext
    {
        public DbSet<LookupTYPE> LookupTYPESet { get; set; }

        public APPLICATIONLookupsDbContext() : base("APPLICATION_DB")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<CustomPoolAndSpaDbContext, Configuration>());

            // There are four database initialization strategies

            // 1. CreateDatabaseIfNotExists (default)

            // Database.SetInitializer<CustomPoolAndSpaDbContext>(new CreateDatabaseIfNotExists<CustomPoolAndSpaDbContext>());

            // 2. DropCreateDatabaseIfModelChanges

            // Database.SetInitializer<CustomPoolAndSpaDbContext>(new DropCreateDatabaseIfModelChanges<CustomPoolAndSpaDbContext>());

            Database.SetInitializer<APPLICATIONLookupsDbContext>(
                new DropCreateDatabaseIfModelChanges<APPLICATIONLookupsDbContext>());

            // 3. DropCreateDatabaseAlways

            // Database.SetInitializer<CustomPoolAndSpaDbContext>(new DropCreateDatabaseAlways<CustomPoolAndSpaDbContext>());

            // 4. Custom DB Initializer

            //Database.SetInitializer<CustomPoolAndSpaDbContext>(new CustomPoolAndSpaDatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //try
            //{
            //    // TODO(crhodes)
            //    // This gives us too many types including the embedded ServiceType and PoolConditionReport
            //    // Need some way of filtering them out, otherwise have to put pointless IsDirty field in them.

            //    modelBuilder.Types()
            //        .Configure(c => c.Ignore("IsDirty"));

            //}
            //catch (InvalidOperationException ex)
            //{
            //    // Ignore
            //}

            base.OnModelCreating(modelBuilder);

            // Do not pluralize table names

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.HasDefaultSchema("Lookup");

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
    }
}
