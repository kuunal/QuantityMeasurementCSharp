// <copyright file="ExceptionEnums.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement.Exceptions
{
    using System;
    using QuantityMeasurement.Enums;
    
    /// <summary>
    /// Custom exception for Quantitiy measurement
    /// </summary>
    /// <seealso cref="System.Exception" />
    class QuantityMeasurementException : Exception
    {
        /// <summary>
        /// The exception type
        /// </summary>
        EXCEPTIONENUMS exceptionType;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityMeasurementException"/> class.
        /// </summary>
        /// <param name="exceptionType">Type of the exception.</param>
        public QuantityMeasurementException(EXCEPTIONENUMS exceptionType) : base(exceptionType.ToString())
        {
            this.exceptionType = exceptionType;
        }
    }
}
