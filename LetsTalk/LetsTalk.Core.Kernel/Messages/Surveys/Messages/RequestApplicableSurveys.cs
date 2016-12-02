using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsTalk.Core.Kernel.Messages.Surveys.Messages
{
    public class RequestApplicableSurveys
    {
        public Guid RequestId { get; set; }

        public Guid UserId { get; set; }
    }
}
