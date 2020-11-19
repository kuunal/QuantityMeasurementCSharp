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
        CATEGORIES category;
        Units unit;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public QuantityMeasurements(double quantity, Units unit)
        {
            try
            {
                this.unit = unit;
                EnumData data = GetDescription(unit);
                if (this.unit == Units.CELSIUS)
                    this.quantity = (quantity * 9 / 5) + 32;
                else
                    this.quantity = quantity * data.value;
                this.category = data.category;
            }
            catch (System.NullReferenceException)
            {
                throw new QuantityMeasurementException(EXCEPTIONENUMS.NULL_VALUE);
            }
        }


        public bool CheckEquals(QuantityMeasurements that)
        {
            if (this.category != that.category)
                throw new QuantityMeasurementException(EXCEPTIONENUMS.UNIT_MISMATCH);
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

        public double addQuantities(params QuantityMeasurements[] quantityMeasurements){
            if (quantityMeasurements.Length == 0)
            {
                return 0;
            }
            else if (quantityMeasurements.Length == 1)
            {
                return quantityMeasurements[0].quantity;
            }
            else
            {
                double total = 0;
                foreach (QuantityMeasurements quantityObject in quantityMeasurements)
                {
                    if (this.category != quantityObject.category)
                        throw new QuantityMeasurementException(EXCEPTIONENUMS.UNIT_MISMATCH);
                    total += quantityObject.quantity;
                }
                return total;
            }
        }
    }
}
