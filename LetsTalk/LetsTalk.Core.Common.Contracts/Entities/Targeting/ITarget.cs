namespace LetsTalk.Core.Common.Contracts.Entities.Targeting
{
    using System;

    public interface ITarget
    {
        Guid TargetId { get; set; }

        Guid EntityId { get; set; }

        string Surname { get; set; }
        string GivenName { get; set; }
        IPhoneNumber Telephone { get; set; }
        DateTime Birthdate { get; set; }
        string EmailAddress { get; set; }
        Gender Gender { get; set; }

        bool IsBillingAddressDiffrent { get; set; }
        IAddress Address { get; set; }

        IAddress BillingAddress { get; set; }
        
    }
}