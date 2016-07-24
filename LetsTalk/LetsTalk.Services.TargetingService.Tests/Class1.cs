using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using LetsTalk.Business.Entities.Miscellaneous;
using LetsTalk.Business.Entities.Targeting;
using LetsTalk.Services.TargetingService.Data;
using Xunit;

namespace LetsTalk.Services.TargetingService.Tests
{
    public class Class1
    {
        
        public void GenerateTargetsIntoDb()
        {
            List<Target> Targets = new List<Target>();
            var repo = new TargetRepository();
            using (var fs = new StreamReader(File.OpenRead(@"Names.csv")))
            {
                fs.ReadLine();
                while (!fs.EndOfStream)
                {
                    
                    string Line = fs.ReadLine();
                    string[] data = Line.Split(',');
                    var target = new Target
                    {
                        TargetId = Guid.NewGuid(),
                        GivenName = data[18],
                        Surname = data[0], 
                        Gender = (data[17] == "Male")? Gender.Male : Gender.Female,
                        Address = new Address { PostalAddress1 = data[1], PostalPlace = data[2], PostalNumber = data[3]},
                        Birthdate = DateTime.ParseExact(data[9], "M/d/yyyy", CultureInfo.InvariantCulture),
                    EmailAddress = data[4],
                        Telephone = new PhoneNumber { Number = data[7]}
                  
                    };
                    repo.Add(target);
               
                }
            }
        }
    }
}
