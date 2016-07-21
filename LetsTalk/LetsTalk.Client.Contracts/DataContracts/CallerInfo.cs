using System;

namespace LetsTalk.Client.Contracts
{
    public class CallerInfo
    {
        public Guid CallerId { get; set; }
        public string CallerName { get; set; }
        public int CallerNumber { get; set; }
    }
}
