using QuantityMeasurement.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement.Exceptions
{
    class QuantityMeasurementException : Exception
    {
        EXCEPTIONENUMS exceptionType;
        public QuantityMeasurementException(EXCEPTIONENUMS exceptionType) : base(exceptionType.ToString())
        {
            this.exceptionType = exceptionType;
        }
    }
}
