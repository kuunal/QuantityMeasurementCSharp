using QuantityMeasurement.Enums;
using QuantityMeasurement.Exceptions;
using System;
using System.ComponentModel;
using System.Reflection;
using static QuantityMeasurement.Enums.EnumData;

namespace QuantityMeasurement
{
    public class QuantityMeasurements
    {

        double quantity;
        CATEGORIES unit; 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public QuantityMeasurements(double quantity, Units unit )
        {
            try
            {
                EnumData data = GetDescription(unit);
                this.quantity = quantity * data.value;
                this.unit = data.category;
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

        public EnumData GetDescription(Units unit)
        {
            var x = unit.ToString();
            var field = unit.GetType().GetField(unit.ToString());
            var attr = field.GetCustomAttributes(typeof(EnumData), false);
            return (attr[0] as EnumData);
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
