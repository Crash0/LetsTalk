#region Header

// <copyright file="MEFLoader.cs" company="GoDialog AS">
// File Created:  2016 07 15
// Last Modified: 2016 201607 16 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>

#endregion

#region Usings

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using LetsTalk.Client.Proxies;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Identity;
using LetsTalk.Core.Common.UI.Events;

#endregion

namespace LetsTalk.Client.Bootstrapper
{
    [Obsolete]
    public static class MEFLoader
    {
        public static CompositionContainer Init()
        {
            return Init(null);
        }

        public static CompositionContainer Init(ICollection<ComposablePartCatalog> catalogParts)
        {
            var catalog = new AggregateCatalog();

            catalog.Catalogs.Add(new AssemblyCatalog(typeof(AuthenticationClient).Assembly));
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(IdentityContainer).Assembly));
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(OpenCallerViewEvent).Assembly));
            if (catalogParts == null)
                return new CompositionContainer(catalog);


            foreach (var catalogPart in catalogParts)
                catalog.Catalogs.Add(catalogPart);

            return new CompositionContainer(catalog);
        }
    }
}