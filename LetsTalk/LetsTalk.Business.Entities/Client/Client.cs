using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Core;

namespace LetsTalk.Business.Entities.Client
{
    public class Client : EntityBase, IIdentifiableEntity
    {
        public Guid ClientId { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }

        public Guid EntityId { get { return ClientId; } set { ClientId = value; } }
        public Guid CorrelationGuid { get; set; }
    }
}
