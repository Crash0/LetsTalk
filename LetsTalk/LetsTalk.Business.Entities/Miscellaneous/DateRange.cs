using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsTalk.Business.Entities.Miscellaneous
{
    using LetsTalk.Core.Common.Contracts.Entities;

    public class DateRange : IDateRange
    {
        public DateTime StartDate { get; set; }

        public DateTime StopDate { get; set; }
    }
}
