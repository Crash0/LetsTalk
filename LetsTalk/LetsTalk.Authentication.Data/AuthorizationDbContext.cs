using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Runtime.Serialization;
using LetsTalk.Business.Entities.Authentication;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Authentication.Data
{
    public class AuthorizationDbContext : DbContext
    {
        
        //Ef Needs This
        public AuthorizationDbContext() : base("name=LetsTalk_Authentication")
        {
            Database.SetInitializer<AuthorizationDbContext>(new DropCreateDatabaseIfModelChanges<AuthorizationDbContext>());
        }

        public DbSet<UserAccount> UserAccountSet { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            modelBuilder.Ignore<PropertyChangedEventHandler>();
            modelBuilder.Ignore<ExtensionDataObject>();
            modelBuilder.Ignore<IIdentifiableEntity>();

            modelBuilder.Entity<UserAccount>()
                .HasKey(e => e.AccountId)
                .Ignore(e => e.EntityId);
        }
    }
}
