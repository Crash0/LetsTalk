using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Business.Entities.Targeting;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Services.TargetingService.Data
{
    public sealed class TargetRepository : IDataRepository<Target>
    {
        public Target Add(Target entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Target> Get()
        {
            throw new NotImplementedException();
        }

        public Target Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Target entity)
        {
            throw new NotImplementedException();
        }

        public Target Update(Target entity)
        {
            throw new NotImplementedException();
        }
    }
}
