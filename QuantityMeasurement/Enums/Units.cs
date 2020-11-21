// <copyright file="ExceptionEnums.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement.Enums
{
    /// <summary>
    /// Custom attribute for providing more data to enum.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    public class EnumData : System.Attribute
    {
        /// <summary>
        /// Categories of units
        /// </summary>
        public enum CATEGORIES
        {
            LENGTH,
            VOLUMES,
            WEIGHTS,
            TEMPERATURE
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public double value { get; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public CATEGORIES category { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumData"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="category">The category.</param>
        public EnumData(double value, CATEGORIES category)
        {
            this.value = value;
            this.category = category;
        }
    }

    /// <summary>
    /// Available units enum 
    /// </summary>
    public enum Units
    {
        [EnumData(12, EnumData.CATEGORIES.LENGTH)]
        FEET,

        [EnumData(1, EnumData.CATEGORIES.LENGTH)]
        INCH,

        [EnumData(36, EnumData.CATEGORIES.LENGTH)]
        YARD,

        [EnumData(0.4, EnumData.CATEGORIES.LENGTH)]
        CENTIMETER,

        [EnumData(1, EnumData.CATEGORIES.VOLUMES)]
        MILILITRE,

        [EnumData(1000, EnumData.CATEGORIES.VOLUMES)]
        LITRE,

        [EnumData(3780, EnumData.CATEGORIES.VOLUMES)]
        GALLON,

        [EnumData(1, EnumData.CATEGORIES.WEIGHTS)]
        KILOGRAM,

        [EnumData(0.001, EnumData.CATEGORIES.WEIGHTS)]
        GRAMS,

        [EnumData(1000, EnumData.CATEGORIES.WEIGHTS)]
        TONNE,

        [EnumData(1, EnumData.CATEGORIES.TEMPERATURE)]
        FARENHEIT,

        [EnumData(1, EnumData.CATEGORIES.TEMPERATURE)]
        CELSIUS
    }
}


