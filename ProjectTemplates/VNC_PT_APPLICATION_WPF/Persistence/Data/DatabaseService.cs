using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using VNC_PT_APPLICATION_WPF.Domain;

namespace VNC_PT_APPLICATION_WPF.Persistence.Data
{
    public class DatabaseService : DbContext, IVNC_PT_APPLICATION_WPFDbContext
    {
        public DbSet<TYPE> TYPESet { get; set; }

        public DatabaseService() : base("VNC_PT_APPLICATION_WPFDB")
        {
            //Database.SetInitializer(new DatabaseInitializer());
            Database.SetInitializer<VNC_PT_APPLICATION_WPFDbContext>(
                new DropCreateDatabaseIfModelChanges<VNC_PT_APPLICATION_WPFDbContext>());
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
        }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}
