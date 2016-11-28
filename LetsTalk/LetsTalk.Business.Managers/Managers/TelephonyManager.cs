// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TelephonyManager.cs" company="GoDialog">
//   All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace LetsTalk.Business.Managers
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ServiceModel;

    using LetsTalk.Business.Contracts;

    #endregion

    /// <summary>
    ///     TODO The telephony manager.
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class TelephonyManager : ManagerBase, ITelephonyService
    {
        /// <summary>
        ///     TODO The current channels.
        /// </summary>
        private static Dictionary<Guid, ITelephonyServiceCallbacks> currentChannels;

        /// <summary>
        ///     Initializes a new instance of the <see cref="TelephonyManager" /> class.
        /// </summary>
        public TelephonyManager()
        {
            currentChannels = new Dictionary<Guid, ITelephonyServiceCallbacks>();
        }

        /// <summary>
        /// TODO The close call.
        /// </summary>
        /// <param name="callId">
        /// TODO The call id.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool CloseCall(string callId)
        {
            return false;
        }

        /// <summary>
        /// TODO The connect.
        /// </summary>
        /// <param name="agentId">
        /// TODO The agent id.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Connect(Guid agentId)
        {
            var s = OperationContext.Current.GetCallbackChannel<ITelephonyServiceCallbacks>();
            currentChannels.Add(agentId, s);
            s.ConnectionSucceeded();
            return true;
        }

        /// <summary>
        ///     TODO The ping.
        /// </summary>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public bool Ping()
        {
            // TODo:  remove manually placed guid
            currentChannels[Guid.Parse("D56F4395-3972-4CA9-9BDE-A4173B1EB051")].CallerConnect(
                new CallerInfo { CallerName = "Jonas deb grå", CallerNumber = 98608900, CallerId = Guid.NewGuid() });
            Console.WriteLine($"Got ping from {OperationContext.Current.Channel.RemoteAddress} at {DateTime.Now}");
            return true;
        }

        /// <summary>
        /// TODO The send call to.
        /// </summary>
        /// <param name="agentId">
        /// TODO The agent id.
        /// </param>
        /// <param name="callInfo">
        /// TODO The call info.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool ITelephonyService.SendCallTo(Guid agentId, CallerInfo callInfo)
        {
            return SendCallTo(agentId, callInfo);
        }

        /// <summary>
        /// TODO The send call to.
        /// </summary>
        /// <param name="agentId">
        /// TODO The agent id.
        /// </param>
        /// <param name="callInfo">
        /// TODO The call info.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private static bool SendCallTo(Guid agentId, CallerInfo callInfo)
        {
            if (currentChannels.ContainsKey(agentId))
            {
                ITelephonyServiceCallbacks callbacks;
                var r = currentChannels.TryGetValue(agentId, out callbacks);
                if (r != true) return false;
                callbacks.CallerConnect(callInfo);
                return true;
            }

            return false;
        }
    }
}