using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Web;
using LetsTalk.Core.Common.Data;

namespace LetsTalkDataService
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