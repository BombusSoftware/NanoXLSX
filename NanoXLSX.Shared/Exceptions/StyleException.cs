﻿/*
 * NanoXLSX is a small .NET library to generate and read XLSX (Microsoft Excel 2007 or newer) files in an easy and native way  
 * Copyright Raphael Stoeckli © 2023
 * This library is licensed under the MIT License.
 * You find a copy of the license in project folder or on: http://opensource.org/licenses/MIT
 */

using System;
using System.Runtime.Serialization;

namespace NanoXLSX.Shared.Exceptions
{
    /// <summary>
    /// Class for exceptions regarding Style incidents
    /// </summary>
    [Serializable]
    public class StyleException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public StyleException()
        { }
        /// <summary>
        /// Constructor with passed message
        /// </summary>
        /// <param name="message">Message of the exception</param>
        public StyleException(string message)
            : base(message)
        { }

        /// <summary>
        /// Constructor with passed message and inner exception
        /// </summary>
        /// <param name="message">Message of the exception</param>
        /// <param name="inner">Inner exception</param>
        public StyleException(string message, Exception inner)
            : base(message, inner)
        { }

        /// <summary>
        /// Constructor for deserialization purpose
        /// </summary>
        /// <param name="info">Serialization info instance</param>
        /// <param name="context">Streaming context</param>
        protected StyleException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }

}
