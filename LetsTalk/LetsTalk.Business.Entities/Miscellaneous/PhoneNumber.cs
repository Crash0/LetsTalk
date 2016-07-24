
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Common.Contracts.Entities;

namespace LetsTalk.Business.Entities.Miscellaneous
{
    public class PhoneNumber : IPhoneNumber
    {
        public string Number { get; set; }
    }
}
