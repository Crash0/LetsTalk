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
                    PostalAddress1 = "Geværveien 14",
                    PostalNumber = "1710",
                    PostalPlace = "Sarpsborg"
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
                    PostalAddress1 = "Dolvenveien 170",
                    PostalNumber = "3267",
                    PostalPlace = "Larvik"
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
                    PostalAddress1 = "Thomas Snekkers gate 223",
                    PostalNumber = "4024",
                    PostalPlace = "Stavanger"
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
                    PostalAddress1 = "Nedre Korskirkeallmenningen 96",
                    PostalNumber = "5017",
                    PostalPlace = "Bergen"
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
                    PostalAddress1 = "Myrfaret 29",
                    PostalNumber = "1697",
                    PostalPlace = "Moss"
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
                    PostalAddress1 = "Kongsvingergata 203",
                    PostalNumber = "0464",
                    PostalPlace = "Oslo"
                }
            }
        };
#endregion

    }
}
