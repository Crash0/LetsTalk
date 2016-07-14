using System;
using System.Runtime.Serialization;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Core;

namespace LetsTalk.Business.Entities.Surveys
{
    [DataContract]
    public class Survey :EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Title { get; set; } 

        [DataMember]
        public string Description { get; set; }
        
        public Guid EntityId
        {
            get { return Id; }
            set { Id = value; }
        }

    }
}
