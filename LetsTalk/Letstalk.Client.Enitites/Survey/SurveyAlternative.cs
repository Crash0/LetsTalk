using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Common.Contracts.Entities;

namespace LetsTalk.Client.Entities
{
    public class SurveyAlternative : ISurveyAlternative
    {
        public SurveyAlternative(string alternative)
        {
            AlternativeId = Guid.NewGuid();
            Alternative = alternative;
        }

        public SurveyAlternative(string alternative, string description) : this(alternative)
        {
            Description = description;

        }

        public bool Selected { get; set; }
        public Guid AlternativeId { get; }
        public Guid OwnerQuestion { get; set; }
        public string Description { get; set; }
        public string Alternative { get; }
    }
}
