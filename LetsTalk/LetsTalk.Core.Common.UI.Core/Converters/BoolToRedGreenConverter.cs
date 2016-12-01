// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BoolToRedGreenConverter.cs" company="GoDialog">
//   Copyright (C) 2016 Jonas Fjeld.
//             This file is part of LetsTalk Software pack.
//             License: Attribution-NonCommercial-ShareAlike 4.0 International.
//             See https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LetsTalk.Core.Common.UI.Converters
{
    #region Usings

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Windows.Data;
    using System.Windows.Media;
    using System.Windows.Shapes;

    #endregion

    /// <summary>
    ///     The bool to red green converter.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
        Justification = "Reviewed. Suppression is OK here.")]
    public class BoolToRedGreenConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Brushes.Green : Brushes.Red;
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}