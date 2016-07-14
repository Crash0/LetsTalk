#region Header

// <copyright file="PropertySupport.cs" company="GoDialog AS">
// File Created:  2016 07 13
// Last Modified: 2016 201607 13 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>

#endregion

#region Usings

using System;
using System.Linq.Expressions;
using System.Reflection;

#endregion

namespace LetsTalk.Core.Common.Utils
{
    public static class PropertySupport
    {
        public static string ExtractPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            if (propertyExpression == null)
                throw new ArgumentNullException(nameof(propertyExpression));

            var memberExpression = propertyExpression.Body as MemberExpression;
            if (memberExpression == null)
                throw new ArgumentException("memberExpression");

            var property = memberExpression.Member as PropertyInfo;
            if (property == null)
                throw new ArgumentException("property");

            var getMethod = property.GetGetMethod(true);
            if (getMethod.IsStatic)
                throw new ArgumentException("static method");

            return memberExpression.Member.Name;
        }
    }
}