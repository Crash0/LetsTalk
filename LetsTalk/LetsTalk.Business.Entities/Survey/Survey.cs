namespace LetsTalk.Business.Entities.Survey
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using LetsTalk.Business.Contracts;
    using LetsTalk.Business.Entities.Miscellaneous;
    using LetsTalk.Core.Common.Contracts;
    using LetsTalk.Core.Common.Contracts.Entities;
    using LetsTalk.Core.Common.Core;

    [DataContract]
    public class Survey :EntityBase, IIdentifiableEntity, ISurvey
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Title { get; set; } 

        [DataMember]
        public string Description { get; set; }
        
        public Guid EntityId
        {
            get { return this.Id; }
            set { this.Id = value; }
        }

        public IDateRange ApplicableAgeGroup { get; set; }
        public List<ISurveyQuestion> Questions { get; set; }
    }
}
