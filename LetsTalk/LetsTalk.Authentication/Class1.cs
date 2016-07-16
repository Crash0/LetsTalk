#region Header
// <copyright file="Class1.cs" company="GoDialog AS">
// File Created:  2016 07 16
// Last Modified: 2016 201607 16 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using System;
using LetsTalk.Core.Kernel;
using LetsTalk.Core.Kernel.Messages;
using NServiceBus;

namespace LetsTalk.Authentication
{

    public class Class1 : IHandleMessages<Ping>
    {
        IBus _bus ;

        public Class1(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(Ping message)
        {
            Console.WriteLine(message.PingPong);
            if (message.PingPong == "Ping")
            {
                message.PingPong = "Pong";
            }
            else
            {
                message.PingPong = "Ping";
            }
            _bus.Send(EndPoint.Backend.ToString(), message);
        }
    }
}