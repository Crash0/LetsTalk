namespace LetsTalk.Client.Contracts
{
    using System.Runtime.Serialization;

    [DataContract]
    public struct ActionOnCustomerCommand
    {
        [DataMember]
        public CommandType CommandType;

        [DataMember]
        public object[] Args;

    }
}