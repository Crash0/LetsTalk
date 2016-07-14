using System;
using System.IO;

namespace LetsTalk.Core.Common.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message)
            :base(message)
        {   
        }

        public NotFoundException(string message, Exception exception)
            :base(message,exception)
        {
        }
    }
}
