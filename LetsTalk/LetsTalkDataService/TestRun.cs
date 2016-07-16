    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsTalkDataService
{
    public class TestRun
    {
        static void Main(string[] args)
        {
            WebRole web = new WebRole();
            web.OnStart();

            Console.ReadKey();
            web.OnStop();
        }
    }
}