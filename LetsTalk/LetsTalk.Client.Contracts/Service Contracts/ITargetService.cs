namespace LetsTalk.Client.Contracts
{
    using System;
    using System.ServiceModel;

    using LetsTalk.Core.Common.Contracts;

    [ServiceContract]
    public interface ITargetingService : IServiceContract
    {
        // This is going to be simplified for network transfer
        // TODO remember to implement CONVersions in clientSide Contract
        [OperationContract]
        ActionOnCustomerCommand[] GetAvailableCommands(Guid targetId);

       [OperationContract]
       bool MarkTargetActionAsComplete(Guid targetId, ActionOnCustomerCommand action);
    }
}
