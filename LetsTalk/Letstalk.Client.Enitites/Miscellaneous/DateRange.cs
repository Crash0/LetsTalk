namespace LetsTalk.Client.Entities.Miscellaneous
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using LetsTalk.Core.Common.Contracts.Entities;

    public class DateRange : IDateRange
    {
        public DateTime StartDate { get; set; }

        public DateTime StopDate { get; set; }
    }
}
