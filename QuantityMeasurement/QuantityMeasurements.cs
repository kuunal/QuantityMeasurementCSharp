// <copyright file="QuantityMeasurements.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement
{
    using System;
    using QuantityMeasurement.Enums;
    using QuantityMeasurement.Exceptions;
    using static QuantityMeasurement.Enums.EnumData;

    /// <summary>
    /// Comparing and addition of quantities.
    /// </summary>
    public class QuantityMeasurements
    {
        /// <summary>
        /// The quantity
        /// </summary>
        private double quantity;

        /// <summary>
        /// The category of unit
        /// </summary>
        private CATEGORIES category;

        /// <summary>
        /// The unit
        /// </summary>
        private Units unit;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityMeasurements"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <param name="unit">The unit.</param>
        /// <exception cref="QuantityMeasurementException">Null value exception</exception>
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

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Checks the equals.
        /// </summary>
        /// <param name="that">other object to compare to.</param>
        /// <returns>Boolean result based on comaprison</returns>
        /// <exception cref="QuantityMeasurementException"></exception>
        public bool CheckEquals(QuantityMeasurements that)
        {
            if (this.category != that.category)
                throw new QuantityMeasurementException(EXCEPTIONENUMS.UNIT_MISMATCH);
            return (this.quantity == that.quantity);
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <returns>String value of description</returns>
        public EnumData GetDescription(Units unit)
        {
            var x = unit.ToString();
            var field = unit.GetType().GetField(unit.ToString());
            var attr = field.GetCustomAttributes(typeof(EnumData), false);
            return (attr[0] as EnumData);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Adds the quantities.
        /// </summary>
        /// <param name="quantityMeasurements">The quantity measurements.</param>
        /// <returns>addition of two quantities in base unit</returns>
        /// <exception cref="QuantityMeasurementException"></exception>
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
