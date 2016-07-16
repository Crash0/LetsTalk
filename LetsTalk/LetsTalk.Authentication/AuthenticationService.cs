#region Header
// <copyright file="AuthenticationService.cs" company="GoDialog AS">
// File Created:  2016 07 16
// Last Modified: 2016 201607 16 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using System;
using LetsTalk.Core.Kernel;
using NServiceBus;

namespace LetsTalk.Authentication
{
    public static class AuthenticationService
    {
        static void Main(string[] args)
        {
            var startableBus = Bus.Create(BusConfigurator.CreateConfig(EndPoint.Authorization));

            using (startableBus.Start())
            {
                Console.ReadLine();
            }


        }   
    }
}