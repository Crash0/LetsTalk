using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Business.Entities.Client;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.ClientService.Data
{
    public class ClientDbContext : DbContext
    {
        public ClientDbContext() : base("name = LetsTalk_Client")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ClientDbContext>());
        }

        public DbSet<Client> ClientSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            modelBuilder.Ignore<PropertyChangedEventHandler>();
            modelBuilder.Ignore<ExtensionDataObject>();
            modelBuilder.Ignore<IIdentifiableEntity>();

            modelBuilder.Entity<Client>().HasKey(k => k.ClientId).Ignore(k => k.EntityId);
        }
    }
}
