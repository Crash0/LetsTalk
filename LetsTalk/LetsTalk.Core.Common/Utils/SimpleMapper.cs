#region Header

// <copyright file="SimpleMapper.cs" company="GoDialog AS">
// File Created:  2016 07 13
// Last Modified: 2016 201607 13 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>

#endregion

#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace LetsTalk.Core.Common.Utils
{
    public static class SimpleMapper
    {
        public static void PropertyMap<T, U>(T source, U destination)
            where T : class, new()
            where U : class, new()
        {
            var sourceProperties = source.GetType().GetProperties().ToList<PropertyInfo>();
            var destinationProperties = destination.GetType().GetProperties().ToList<PropertyInfo>();

            foreach (var sourceProperty in sourceProperties)
            {
                var destinationProperty = destinationProperties.Find(item => item.Name == sourceProperty.Name);

                if (destinationProperty != null)
                {
                    try
                    {
                        destinationProperty.SetValue(destination, sourceProperty.GetValue(source, null), null);
                    }
                    catch (ArgumentException)
                    {
                    }
                }
            }
        }
    }
}