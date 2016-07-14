using LetsTalk.Core.Common.BusinessEngine;
using LetsTalk.Core.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Common.Core;

namespace LetsTalk.Core.Common.BusinessEngine
{
    class BusinessEngineFactory : IBusinessFactory
    {
        public T GetBusinessEngine<T>() where T : IBusinessEngine
        {
            return ObjectBase.Container.GetExportedValue<T>();
        }
    }
}
