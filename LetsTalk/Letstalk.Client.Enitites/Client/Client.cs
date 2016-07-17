using LetsTalk.Core.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Letstalk.Client.Entities
{

    public class Client : ObjectBase
    {
        private Guid _ClientId;
        public Guid ClientId {
            get { return _ClientId; }
            set { _ClientId = value; }
        }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }

    }
}
