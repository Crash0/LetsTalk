using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Business.Contracts.Entities;

namespace LetsTalk.Business.Entities.Miscellaneous
{
    public class Address : IAddress
    {
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalPlace { get; set; }
        public string PostalNumber { get; set; }

    }
}
