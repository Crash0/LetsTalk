// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TargetRepository.cs" company="GoDialog">
//   Copyright (C) 2016 Jonas Fjeld.
//             This file is part of LetsTalk Software pack.
//             License: Attribution-NonCommercial-ShareAlike 4.0 International.
//             See https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LetsTalk.Services.TargetingService.Data
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Linq;

    using LetsTalk.Business.Entities.Targeting;
    using LetsTalk.Core.Common.Data;
    using LetsTalk.Services.TargetingService.Contracts;

    #endregion

    /// <summary>
    /// TODO The target repository.
    /// </summary>
    [Export(typeof(ITargetRepository))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public sealed class TargetRepository : DataRepositoryBase<Target, TargetServiceDbContext>, ITargetRepository
    {
        /// <summary>
        /// TODO The add entity.
        /// </summary>
        /// <param name="entityContext">
        /// TODO The entity context.
        /// </param>
        /// <param name="entity">
        /// TODO The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Target"/>.
        /// </returns>
        protected override Target AddEntity(TargetServiceDbContext entityContext, Target entity)
        {
            return entityContext.TargetSet.Add(entity);
        }

        /// <summary>
        /// TODO The get entities.
        /// </summary>
        /// <param name="entityContext">
        /// TODO The entity context.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        [Obsolete]
        protected override IEnumerable<Target> GetEntities(TargetServiceDbContext entityContext)
        {
            return from t in entityContext.TargetSet select t;
        }

        /// <summary>
        /// TODO The get entity.
        /// </summary>
        /// <param name="entityContext">
        /// TODO The entity context.
        /// </param>
        /// <param name="id">
        /// TODO The id.
        /// </param>
        /// <returns>
        /// The <see cref="Target"/>.
        /// </returns>
        protected override Target GetEntity(TargetServiceDbContext entityContext, Guid id)
        {
            var query = from e in entityContext.TargetSet where e.TargetId == id select e;
            return query.FirstOrDefault();
        }

        /// <summary>
        /// TODO The update entity.
        /// </summary>
        /// <param name="entityContext">
        /// TODO The entity context.
        /// </param>
        /// <param name="entity">
        /// TODO The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Target"/>.
        /// </returns>
        protected override Target UpdateEntity(TargetServiceDbContext entityContext, Target entity)
        {
            var query = from e in entityContext.TargetSet where e.TargetId == entity.TargetId select e;
            return query.FirstOrDefault();
        }
    }
}