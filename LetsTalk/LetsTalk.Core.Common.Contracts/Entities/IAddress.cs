// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAddress.cs" company="GoDialog">
//   Copyright (C) 2016 Jonas Fjeld.
//             This file is part of LetsTalk Software pack.
//             License: Attribution-NonCommercial-ShareAlike 4.0 International.
//             See https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LetsTalk.Core.Common.Contracts.Entities
{
    #region Usings

    using System.Diagnostics.CodeAnalysis;

    #endregion

    /// <summary>
    ///     Represents a Address.
    ///     A address can include fields such as street address, postal code, state/province, and country or region.
    ///     This Interface is Created Upon The <see cref="T:System.Devices.Location.CivicAddress"/>.
    ///     This needed custom implementation, so is just used for a basis for further work. 
    ///     TODO: Remove Unnecessary Properties
    /// </summary>
    public interface IAddress
    {
        /// <summary>
        ///     Gets or sets the first line of the address.
        /// </summary>
        /// <returns>
        ///     Returns the first line of the address. If the data is not provided, returns
        ///     <see cref="F:System.String.Empty" />.
        /// </returns>
        string AddressLine1 { get; set; }

        /// <summary>
        ///     Gets or sets the second line of the address.
        /// </summary>
        /// <returns>
        ///     Returns the second line of the address. If the data is not provided, returns
        ///     <see cref="F:System.String.Empty." />
        /// </returns>
        string AddressLine2 { get; set; }

        /// <summary>Gets or sets the building name or number.</summary>
        /// <returns>
        ///     Returns the building name or number. If the data is not provided, returns <see cref="F:System.String.Empty" />
        ///     .
        /// </returns>
        string Building { get; set; }

        /// <summary>Gets or sets the name of the city.</summary>
        /// <returns>Returns the name of the city. If the data is not provided, returns <see cref="F:System.String.Empty" />.</returns>
        string City { get; set; }

        /// <summary>Gets or sets the country or region of the location.</summary>
        /// <returns>Returns the country or region code. If the data is not provided, returns <see cref="F:System.String.Empty" />.</returns>
        string CountryRegion { get; set; }

        /// <summary>Gets or sets the floor level of the location.</summary>
        /// <returns>
        ///     Returns a string that contains the floor level. If the data is not provided, returns
        ///     <see cref="F:System.String.Empty" />.
        /// </returns>
        string FloorLevel { get; set; }

        /// <summary>
        ///     Gets a value that indicates whether the <see cref="T:LetsTalk.Core.Common.Contracts.Entities.IAddress" /> contains
        ///     data.
        /// </summary>
        /// <returns>
        ///     true if the <see cref="T:LetsTalk.Core.Common.Contracts.Entities.IAddress" /> is equal to
        ///     <see cref="F:LetsTalk.Core.Common.Contracts.Entities.IAddress.Unknown" />; otherwise, false.
        /// </returns>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1623:PropertySummaryDocumentationMustMatchAccessors",
            Justification = "Reviewed. Suppression is OK here.")]
        bool IsUnknown { get; }

        /// <summary>Gets or sets the postal code of the location.</summary>
        /// <returns>
        ///     Returns the postal code of the location. If the data is not provided, returns
        ///     <see cref="F:System.String.Empty" />.
        /// </returns>
        string PostalCode { get; set; }

        /// <summary>Gets or sets the state or province of the location.</summary>
        /// <returns>
        ///     Returns the state or province of the location. If the data is not provided, returns
        ///     <see cref="F:System.String.Empty" />.
        /// </returns>
        string StateProvince { get; set; }
    }
}