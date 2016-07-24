using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Common.Data;

namespace LetsTalk.Services.SurveyService
{
    public static class Bootstrapper
    {
        public static CompositionContainer Init()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(Bootstrapper).Assembly));
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(DataRepositoryFactory).Assembly));
            var container = new CompositionContainer(catalog);
            return container;
        }
    }
}
