using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsTalk.Core.Common.Contracts
{
    public interface IIdentityContainer
    {
        string GetAuthenticationToken();

    }
}
