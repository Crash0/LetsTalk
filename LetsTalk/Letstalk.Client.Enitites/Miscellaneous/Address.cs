// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Address.cs" company="GoDialog">
//   Copyright (C) 2016 Jonas Fjeld.
//             This file is part of LetsTalk Software pack.
//             License: Attribution-NonCommercial-ShareAlike 4.0 International.
//             See https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Letstalk.Client.Entities.Miscellaneous
{
    #region Usings

    using System;
    using System.Diagnostics.CodeAnalysis;

    using LetsTalk.Core.Common.Contracts.Entities;

    #endregion

    /// <summary>
    ///     Represents a Address.
    /// </summary>
    public class Address : IAddress
    {
        /// <summary>
        ///     Represents a <see cref="LetsTalk.Core.Common.Contracts.Entities.IAddress" /> That contains no data.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate",
            Justification = "Reviewed. Suppression is OK here.")]
        public static IAddress Unknown = new Address();

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:Letstalk.Client.Entities.Miscellaneous.Address" /> class.
        /// </summary>
        public Address()
        {
            this.AddressLine1 = string.Empty;
            this.AddressLine2 = string.Empty;
            this.Building = string.Empty;
            this.City = string.Empty;
            this.CountryRegion = string.Empty;
            this.FloorLevel = string.Empty;
            this.PostalCode = string.Empty;
            this.StateProvince = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Letstalk.Client.Entities.Miscellaneous.Address"/> class
        ///     using address information.
        /// </summary>
        /// <param name="addressLine1">
        /// A string containing the first line of the street address.
        /// </param>
        /// <param name="addressLine2">
        /// A string containing the second line of the street address.
        /// </param>
        /// <param name="building">
        /// A string containing the building name or number.
        /// </param>
        /// <param name="city">
        /// A string containing the city.
        /// </param>
        /// <param name="countryRegion">
        /// A string containing the country or region.
        /// </param>
        /// <param name="floorLevel">
        /// A string containing the floor number.
        /// </param>
        /// <param name="postalCode">
        /// A string containing the postal code.
        /// </param>
        /// <param name="stateProvince">
        /// A string containing the state or province.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// At least one parameter must be a non-empty string.
        /// </exception>
        public Address(
            string addressLine1,
            string addressLine2,
            string building,
            string city,
            string countryRegion,
            string floorLevel,
            string postalCode,
            string stateProvince)
            : this()
        {
            var flag = false;
            if (!string.IsNullOrEmpty(addressLine1))
            {
                flag = true;
                this.AddressLine1 = addressLine1;
            }

            if (!string.IsNullOrEmpty(addressLine2))
            {
                flag = true;
                this.AddressLine2 = addressLine2;
            }

            if (!string.IsNullOrEmpty(building))
            {
                flag = true;
                this.Building = building;
            }

            if (!string.IsNullOrEmpty(city))
            {
                flag = true;
                this.City = city;
            }

            if (!string.IsNullOrEmpty(countryRegion))
            {
                flag = true;
                this.CountryRegion = countryRegion;
            }

            if (!string.IsNullOrEmpty(floorLevel))
            {
                flag = true;
                this.FloorLevel = floorLevel;
            }

            if (!string.IsNullOrEmpty(postalCode))
            {
                flag = true;
                this.PostalCode = postalCode;
            }

            if (!string.IsNullOrEmpty(stateProvince))
            {
                flag = true;
                this.StateProvince = stateProvince;
            }

            if (!flag) throw new ArgumentException("Argument_RequiresAtLeastOneNonEmptyStringParameter");
        }

        /// <summary>
        ///     Gets or sets the first line of the address.
        /// </summary>
        /// <returns>
        ///     Returns the first line of the address. If the data is not provided, returns
        ///     <see cref="F:System.String.Empty" />.
        /// </returns>
        public string AddressLine1 { get; set; }

        /// <summary>
        ///     Gets or sets the second line of the address.
        /// </summary>
        /// <returns>
        ///     Returns the second line of the address. If the data is not provided, returns
        ///     <see cref="F:System.String.Empty." />
        /// </returns>
        public string AddressLine2 { get; set; }

        /// <summary>Gets or sets the building name or number.</summary>
        /// <returns>
        ///     Returns the building name or number. If the data is not provided, returns <see cref="F:System.String.Empty" />
        ///     .
        /// </returns>
        public string Building { get; set; }

        /// <summary>Gets or sets the name of the city.</summary>
        /// <returns>Returns the name of the city. If the data is not provided, returns <see cref="F:System.String.Empty" />.</returns>
        public string City { get; set; }

        /// <summary>Gets or sets the country or region of the location.</summary>
        /// <returns>Returns the country or region code. If the data is not provided, returns <see cref="F:System.String.Empty" />.</returns>
        public string CountryRegion { get; set; }

        /// <summary>Gets or sets the floor level of the location.</summary>
        /// <returns>
        ///     Returns a string that contains the floor level. If the data is not provided, returns
        ///     <see cref="F:System.String.Empty" />.
        /// </returns>
        public string FloorLevel { get; set; }

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
        public bool IsUnknown
        {
            get
            {
                if (string.IsNullOrEmpty(this.AddressLine1) && string.IsNullOrEmpty(this.AddressLine2)
                    && string.IsNullOrEmpty(this.Building) && string.IsNullOrEmpty(this.City)
                    && string.IsNullOrEmpty(this.CountryRegion) && string.IsNullOrEmpty(this.FloorLevel)
                    && string.IsNullOrEmpty(this.PostalCode))
                {
                    return string.IsNullOrEmpty(this.StateProvince);
                }

                return false;
            }
        }

        /// <summary>Gets or sets the postal code of the location.</summary>
        /// <returns>
        ///     Returns the postal code of the location. If the data is not provided, returns
        ///     <see cref="F:System.String.Empty" />.
        /// </returns>
        public string PostalCode { get; set; }

        /// <summary>Gets or sets the state or province of the location.</summary>
        /// <returns>
        ///     Returns the state or province of the location. If the data is not provided, returns
        ///     <see cref="F:System.String.Empty" />.
        /// </returns>
        public string StateProvince { get; set; }
    }
}