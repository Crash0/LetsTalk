using System;
using System.ComponentModel.Composition.Hosting;
using LetsTalk.Authentication.Data;
using LetsTalk.Core.Common.Data;
using LetsTalk.Services.SurveyService.Data;

namespace LetsTalk.Business.Bootstrapper
{
    //todo: This should be exclusive to eatch project
    public static class MEFLoader
    {
        [Obsolete]
        public static CompositionContainer Init()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(UserAccountRepository).Assembly));
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(SurveyRepository).Assembly));
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(DataRepositoryFactory).Assembly));
            var container = new CompositionContainer(catalog);
            return container;
        }
    }
}