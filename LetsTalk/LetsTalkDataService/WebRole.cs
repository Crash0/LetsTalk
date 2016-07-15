using System;
using System.Collections.Generic;
using System.Linq;
using SM = System.ServiceModel;
using System.ServiceModel.Web;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;
using LetsTalk.Business.Managers;

namespace LetsTalkDataService
{
    public class WebRole : RoleEntryPoint
    {
        private SM.ServiceHost _authenticationServiceHost;
        public override bool OnStart()
        {

            try
            {
                _authenticationServiceHost = new WebServiceHost(typeof(AuthenticationManager));
                _authenticationServiceHost.Open();

                return true;

            }
            catch (Exception exception)
            {

                throw;
                return false;
            }
        }

        public override void OnStop()
        {
            _authenticationServiceHost.Close();
        }
    }
}
