﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace LetsTalk.Surveys
{
    class EndPointConfiguration : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
            
        }
    }
}
