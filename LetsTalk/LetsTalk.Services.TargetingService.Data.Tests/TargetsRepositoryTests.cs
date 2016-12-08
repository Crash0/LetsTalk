using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Business.Entities.Miscellaneous;
using LetsTalk.Business.Entities.Targeting;
using Xunit;
using LetsTalk.Services.TargetingService.Data;

namespace LetsTalk.Services.TargetingService.Data.Tests
{
    using LetsTalk.Core.Common.Contracts.Entities;

    public class TargetsRepositoryTests
    {
        List<Target> testTargets = new List<Target>
        #region TestList
        
        {
            new Target
            {
                TargetId = Guid.NewGuid(),
                Surname = "Øverland",
                GivenName = "Amalia",
                Telephone = new PhoneNumber { Number = "93365321"},
                Birthdate = new DateTime(1963,7,7),
                EmailAddress = "Amaliaverland@armyspy.com",
                Gender = Gender.Female,
                Address = new Address
                {
                    AddressLine1 = "Geværveien 14",
                    PostalCode = "1710",
                    StateProvince  = "Sarpsborg"
                }
            },
            new Target
            {
                TargetId = Guid.NewGuid(),
                Surname = "Bergerud",
                GivenName = "Amalia",
                Telephone = new PhoneNumber { Number = "93365321"},
                Birthdate = new DateTime(1963,7,7),
                EmailAddress = "DanielBergerud@teleworm.us",
                Gender = Gender.Female,
                Address = new Address
                {
                    AddressLine1 = "Dolvenveien 170",
                    PostalCode = "3267",
                    StateProvince = "Larvik"
                }
            },
            new Target
            {
                TargetId = Guid.NewGuid(),
                Surname = "Hansen",
                GivenName = "Amalia",
                Telephone = new PhoneNumber { Number = "93365321"},
                Birthdate = new DateTime(1963,7,7),
                EmailAddress = "Amaliaverland@armyspy.com",
                Gender = Gender.Female,
                Address = new Address
                {
                    AddressLine1 = "Thomas Snekkers gate 223",
                    PostalCode = "4024",
                    StateProvince = "Stavanger"
                }
            },
            new Target
            {
                TargetId = Guid.NewGuid(),
                Surname = "Sørensen",
                GivenName = "Amalia",
                Telephone = new PhoneNumber { Number = "93365321"},
                Birthdate = new DateTime(1963,7,7),
                EmailAddress = "Amaliaverland@armyspy.com",
                Gender = Gender.Female,
                Address = new Address
                {
                    AddressLine1 = "Nedre Korskirkeallmenningen 96",
                    PostalCode = "5017",
                    StateProvince = "Bergen"
                }
            },
            new Target
            {
                TargetId = Guid.NewGuid(),
                Surname = "Abrahamsen",
                GivenName = "Amalia",
                Telephone = new PhoneNumber { Number = "93365321"},
                Birthdate = new DateTime(1963,7,7),
                EmailAddress = "Amaliaverland@armyspy.com",
                Gender = Gender.Female,
                Address = new Address
                {
                    AddressLine1 = "Myrfaret 29",
                    PostalCode = "1697",
                    StateProvince = "Moss"
                }
            },
            new Target
            {
                TargetId = Guid.NewGuid(),
                Surname = "Samuelsen",
                GivenName = "Amalia",
                Telephone = new PhoneNumber { Number = "93365321"},
                Birthdate = new DateTime(1963,7,7),
                EmailAddress = "Amaliaverland@armyspy.com",
                Gender = Gender.Female,
                Address = new Address
                {
                    AddressLine1 = "Kongsvingergata 203",
                    PostalCode = "0464",
                    StateProvince = "Oslo"
                }
            }
        };
#endregion

    }
}
