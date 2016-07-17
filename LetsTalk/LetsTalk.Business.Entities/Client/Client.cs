using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Core;

namespace LetsTalk.Business.Entities
{
    [DataContract]
    public class Client : EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public Guid ClientId { get; set; }

        [DataMember]
        public string GivenName { get; set; }

        [DataMember]
        public string FamilyName { get; set; }

        [DataMember]
        public string Email { get; set; }


        public Guid EntityId { get { return ClientId; } set { ClientId = value; } }
        public Guid CorrelationGuid { get; set; }
    }
}
