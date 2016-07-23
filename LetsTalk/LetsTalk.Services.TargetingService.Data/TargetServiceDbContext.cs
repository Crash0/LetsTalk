using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Runtime.Serialization;
using LetsTalk.Business.Entities.Targeting;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Services.TargetingService.Data
{
    public class TargetServiceDbContext : DbContext
    {
        public TargetServiceDbContext() : base("name=LetsTalk_TargetServiceDb")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TargetServiceDbContext>());
        }

        public DbSet<Target> TargetSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            modelBuilder.Ignore<PropertyChangedEventHandler>();
            modelBuilder.Ignore<ExtensionDataObject>();
            modelBuilder.Ignore<IIdentifiableEntity>();

            modelBuilder.Entity<Target>()
                .HasKey(e => e.TargetId)
                .Ignore(e => e.EntityId);
        }

    }
    }
}