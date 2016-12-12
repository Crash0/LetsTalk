#region Header
// <copyright file="ITimecardUser.cs" company="GoDialog AS">
// File Created:  12/12-2016
// Last Modified: 12/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using System.Collections.Generic;

namespace LetsTalk.Core.Common.Contracts.Entities.Timecard
{
    public interface ITimecardUser
    {
        ICollection<ITimecard> Timecards { get; set; 

        /*
         * TODO: Add methods for stamping inn and out times from Time service.
         */
    }
}