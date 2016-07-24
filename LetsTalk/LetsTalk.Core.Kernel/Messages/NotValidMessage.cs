#region Header
// <copyright file="Class1.cs" company="GoDialog AS">
// File Created:  2016 07 24
// Last Modified: 2016 201607 24 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion
namespace LetsTalk.Core.Kernel.Messages
{
    public class NotValidMessage
    {
        private readonly string _message;

        public NotValidMessage(string message)
        {
            _message = message;
        }
    }
}