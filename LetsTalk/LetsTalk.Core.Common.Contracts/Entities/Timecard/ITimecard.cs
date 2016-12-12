using System;

namespace LetsTalk.Core.Common.Contracts.Entities.Timecard
{
    public interface ITimecard
    {
        Guid TimecardId { get; }
        DateTime ClockInTime { get; }
        DateTime ClockOutTime { get; }
        string IpAddress { get; }
    }
}