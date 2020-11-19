using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace QuantityMeasurement.Enums
{
    public class EnumData : System.Attribute
    {
        public enum CATEGORIES
        {
            LENGTH
        }
        public double value { get; }
        public CATEGORIES category { get; set; }
        public EnumData() { }

        public EnumData(double value, CATEGORIES category)
        {
            this.value = value;
            this.category = category;
        }
    }
    public enum Units
    {
        [EnumData(12, EnumData.CATEGORIES.LENGTH)]
        FEET,

        [EnumData(1, EnumData.CATEGORIES.LENGTH)]
        INCH,

        [EnumData(36, EnumData.CATEGORIES.LENGTH)]
        YARD,

        [EnumData(0.4, EnumData.CATEGORIES.LENGTH)]
        CENTIMETER
    }



}


