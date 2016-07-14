using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsTalk.Business.Constants
{
    public static class DbConstants
    {
        public const string AuthorizeDatabaseConnectionString =
            "Server=(localdb)\\mssqllocaldb;" +
            "Database=LetsTalk.Authentication;" +
            "Trusted_Connection=True;MultipleActiveResultSets=true";
    }
}
