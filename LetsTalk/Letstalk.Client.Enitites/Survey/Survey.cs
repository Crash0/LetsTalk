using System;

namespace Letstalk.Client.Entities.Survey
{
    public class Survey 
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
