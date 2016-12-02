namespace LetsTalk.Client.Contracts
{
    using System.Runtime.Serialization;

    using LetsTalk.Core.Common.ServiceModel.Constants;

    [DataContract(Name = DatacontractNames.CommandType)]
    public enum CommandType
    {
        [EnumMember]
        Survey,
        [EnumMember]
        Sale
    }
}