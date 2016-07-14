using LetsTalk.Business.Entities.Surveys;
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
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Surveys.Data
{
    public class SurveyDbContext : DbContext
    {
        public SurveyDbContext() : base("name=LetsTalk_Survey")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SurveyDbContext>());
        }

        public DbSet<Survey> SurveySet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            modelBuilder.Ignore<PropertyChangedEventHandler>();
            modelBuilder.Ignore<ExtensionDataObject>();
            modelBuilder.Ignore<IIdentifiableEntity>();

            modelBuilder.Entity<Survey>()
                .HasKey(e => e.Id)
                .Ignore(e => e.EntityId);

        }
    }
}
