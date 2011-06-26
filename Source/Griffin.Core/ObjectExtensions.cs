﻿using System;
using System.Diagnostics.Contracts;

namespace Griffin.Core
{
    /// <summary>
    /// Extensions used to work with objects
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Cast object
        /// </summary>
        /// <typeparam name="T">Type that we are casting to</typeparam>
        /// <param name="instance">Instance being casted.</param>
        /// <returns>Casted object</returns>
        /// <remarks>
        /// No conversions are being made.
        /// </remarks>
        public static T As<T>(this object instance)
        {
            return (T) instance;
        }

        /// <summary>
        /// Convert one type to another type
        /// </summary>
        /// <typeparam name="T">Target type</typeparam>
        /// <param name="instance">Object to convert</param>
        /// <returns>Created object</returns>
        /// <example>
        /// <code>
        /// <![CDATA[
        ///     int myAge = "18".Convert();
        /// ]]>
        /// </code>
        /// </example>
        public static T ConvertTo<T>(this object instance)
        {
            return (T) Converter.Convert(instance, typeof (T));
        }

        /*
        public static T OrDefault<T>(this T instance, T defaultValue)
        {
            if (instance is string)
            {
                return (string)string.IsNullOrEmpty(instance.As<string>()) ? defaultValue : instance;
            }

            if (instance == default(T) ||  )
        }
         * */
    }
}