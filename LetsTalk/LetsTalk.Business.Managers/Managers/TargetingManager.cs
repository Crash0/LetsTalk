#region Header
// <copyright file="TargetingManager.cs" company="GoDialog AS">
// File Created:  02/12-2016
// Last Modified: 02/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion
namespace LetsTalk.Business.Managers
{
    using System;
    using System.ServiceModel;

    using LetsTalk.Business.Contracts;

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class TargetingManager : ManagerBase, ITargetingService
    {
        public ActionOnCustomerCommand[] GetAvailableCommands(Guid targetId)
        {
            // TODO: Implement
            // Get available commands on a customer 
            return new ActionOnCustomerCommand[]
                       { new ActionOnCustomerCommand() { Args = { }, CommandType = CommandType.Survey } };
        }

        public bool MarkTargetActionAsComplete(Guid targetId, ActionOnCustomerCommand action)
        {

            throw new NotImplementedException();
        }
    }
}