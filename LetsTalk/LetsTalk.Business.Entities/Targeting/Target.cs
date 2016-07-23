﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Business.Entities.Miscellaneous;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Business.Entities.Targeting
{
    public sealed class Target : IIdentifiableEntity
    {
        public Guid TargetId { get; set; }

        public Guid EntityId
        {
            get { return TargetId; }
            set { TargetId = value; }
        }

        public string Surname { get; set; }
        public string GivenName { get; set; }
        public PhoneNumber Telephone { get; set; }
        public DateTime Birthdate { get; set; }
        public string EmailAddress { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }
    }
}
