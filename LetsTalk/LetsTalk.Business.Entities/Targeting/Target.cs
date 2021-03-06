﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Business.Entities.Miscellaneous;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Business.Entities.Targeting
{
    using LetsTalk.Core.Common.Contracts.Entities;
    using LetsTalk.Core.Common.Contracts.Entities.Targeting;

    public sealed class Target : IIdentifiableEntity, ITarget
    {
        public Guid TargetId { get; set; }

        public Guid EntityId
        {
            get { return TargetId; }
            set { TargetId = value; }
        }

        public string Surname { get; set; }
        public string GivenName { get; set; }
        public IPhoneNumber Telephone { get; set; }
        public DateTime Birthdate { get; set; }
        public string EmailAddress { get; set; }
        public Gender Gender { get; set; }

        public bool IsBillingAddressDiffrent { get; set; }

        public IAddress Address { get; set; }

        public IAddress BillingAddress { get; set; }
    }
}
