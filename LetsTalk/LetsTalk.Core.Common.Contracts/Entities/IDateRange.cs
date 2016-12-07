
namespace LetsTalk.Core.Common.Contracts.Entities
{
    using System;

    public interface IDateRange
    {
        DateTime StartDate { get; set; }

        DateTime StopDate { get; set; }
    }
}