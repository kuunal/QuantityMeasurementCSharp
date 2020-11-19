using QuantityMeasurement.Enums;
using QuantityMeasurement.Exceptions;
using System;
using System.ComponentModel;
using System.Reflection;

namespace QuantityMeasurement
{
    public class QuantityMeasurements
    {

        double quantity;
        string unit; 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public QuantityMeasurements(double quantity, Units unit )
        {
            try
            {
                this.quantity = quantity * (double)unit;
                this.unit = GetDescription(unit);
            }
            catch (System.NullReferenceException)
            {
                throw new QuantityMeasurementException(EXCEPTIONENUMS.NULL_VALUE);
            }
        } 


        public bool CheckEquals(QuantityMeasurements that)
        {
            if (this.unit != that.unit)
                throw new QuantityMeasurementException(EXCEPTIONENUMS.QUANTITY_MISMATCH);
            return (this.quantity == that.quantity);
        }

        public string GetDescription(Units unit)
        {
            var field = unit.GetType().GetField(unit.ToString());
            var attr = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attr[0] as DescriptionAttribute).Description;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (this == obj)
                return true;
            if (this.GetType() == obj.GetType())
                return true;
            return false;
        }
    }
}
