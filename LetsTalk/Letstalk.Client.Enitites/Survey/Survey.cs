using System;
using LetsTalk.Core.Common.Core;

namespace Letstalk.Client.Entities
{
    public class Survey : ObjectBase
    {
        public Guid Id { get; set; }
        
        public string Title { get; set; } 
        
        public string Description { get; set; }
        
        public Guid EntityId
        {
            get { return Id; }
            set { Id = value; }
        }

    }
}
