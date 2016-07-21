using System;

namespace LetsTalk.Client.Contracts
{
    public interface ICallerInfo
    {
        Guid CallerId { get; set; }
        string CallerName { get; set; }
        int CallerNumber { get; set; }
    }

    public class CallerInfo : ICallerInfo
    {
        public Guid CallerId { get; set; }
        public string CallerName { get; set; }
        public int CallerNumber { get; set; }
    }
}
