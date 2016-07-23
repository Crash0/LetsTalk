#region Header
// <copyright file="ITargetRepository.cs" company="GoDialog AS">
// File Created:  2016 07 23
// Last Modified: 2016 201607 23 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using LetsTalk.Business.Entities.Targeting;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Services.TargetingService.Data
{
    public interface ITargetRepository: IDataRepository<Target>
    {
        
    }
}