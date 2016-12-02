// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITargetingService.cs" company="GoDialog">
//   Copyright (C) 2016 Jonas Fjeld.
//             This file is part of LetsTalk Software pack.
//             License: Attribution-NonCommercial-ShareAlike 4.0 International.
//             See https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace LetsTalk.Business.Contracts
{
    using System;
    using System.ServiceModel;

    /// <summary>
    /// TODO The TargetingService interface.
    /// </summary>
    [ServiceContract]
    public interface ITargetingService
    {
        // This is going to be simplified for network transfer
        // TODO remember to implement CONVersions in clientSide Contract
        [OperationContract]
        ActionOnCustomerCommand[] GetAvailableCommands(Guid targetId);

        [OperationContract]
        bool MarkTargetActionAsComplete(Guid targetId, ActionOnCustomerCommand action);
    }
}