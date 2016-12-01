// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TelephonyManager.cs" company="GoDialog">
//   Copyright (C) 2016 Jonas Fjeld.
//             This file is part of LetsTalk Software pack.
//             License: Attribution-NonCommercial-ShareAlike 4.0 International.
//             See https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
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
            if (currentChannels.ContainsKey(agentId))
            {
                currentChannels.Remove(agentId);

                // TODO: report to service bus that agent is no longer available

                // TODO: Implement connection failed and its ConnectionFailed args
                s.ConnectionFailed(new ConnectionFailedInfo());
                s.ServerDisconnect();
                return false;
            }

            currentChannels.Add(agentId, s);
            s.ConnectionSucceeded();
            return true;
        }

        /// <summary>
        /// Disconnects a Agent from the Phone System
        /// </summary>
        /// <param name="agentId">
        /// The Agent to disconnect
        /// </param>
        /// <returns>
        /// Returns false if the agent is not in the list of current users
        /// </returns>
        public bool Disconnect(Guid agentId)
        {
            if (currentChannels.ContainsKey(agentId))
            {
                currentChannels[agentId].ServerDisconnect();
                currentChannels.Remove(agentId);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        ///     TODO Remove Test Function
        /// </summary>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public bool Ping()
        {
            // Callback Works !!
            // TODo:  remove manually placed guid
            currentChannels[Guid.Parse("D56F4395-3972-4CA9-9BDE-A4173B1EB051")].CallerConnect(
                new CallerInfo
                    {
                        CallerName = "Jonas deb grå " + new Random().Next(390),
                        CallerNumber = new Random().Next(90000000, 99999999),
                        CallerId = Guid.NewGuid()
                    });
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