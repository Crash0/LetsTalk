﻿using System;
using System.Runtime.Serialization;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Core;

namespace LetsTalk.Business.Entities.Authentication
{
    using LetsTalk.Core.Common.Contracts.Entities.Authentication;
    [DataContract]
    public class UserAccount : EntityBase, IIdentifiableEntity, IUserAccount
    {
        [DataMember]
        public Guid AccountId { get; set; }

        [DataMember]
        public Guid CorrelationGuid { get; set; }

        public Guid EntityId
        {
            get { return AccountId; }
            set { AccountId = value; }
        }

        [DataMember]
        public string LoginEmail { get; set; }
    }
}