using System;
using Letstalk.Client.Entities.Miscellaneous;
using LetsTalk.Client.Entities.Miscellaneous;
using LetsTalk.Core.Common.Contracts;

namespace Letstalk.Client.Entities.Targeting
{
    using LetsTalk.Core.Common.Contracts.Entities;
    using LetsTalk.Core.Common.Contracts.Entities.Targeting;
    
    public class Target : IIdentifiableEntity, ITarget
    {
        public Guid TargetId { get; set; }

        public Guid EntityId
        {
            get { return TargetId; }
            set { TargetId = value; }
        }

        public string Surname { get; set; }
        public string GivenName { get; set; }

        public string DisplayFullname => this.Surname + ", " + this.GivenName; 
        public IPhoneNumber Telephone { get; set; }
        public DateTime Birthdate { get; set; }
        public string EmailAddress { get; set; }
        public Gender Gender { get; set; }

        public bool IsBillingAddressDiffrent { get; set; }

        public IAddress Address { get; set; }

        public IAddress BillingAddress { get; set; }

        public bool IsBillingAddressSame
        {
            get { return !this.IsBillingAddressDiffrent; }
            set { IsBillingAddressDiffrent = !value; }
        }
    }
}
