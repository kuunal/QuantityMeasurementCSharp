using NUnit.Framework;
using QuantityMeasurement;
using QuantityMeasurement.Enums;

namespace QuantityMeasurementTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenFeet_WhenEqual_ShouldReturnTrue()
        {
            QuantityMeasurements feet = new QuantityMeasurements(0.0, Units.FEET);
            QuantityMeasurements inch = new QuantityMeasurements(0.0, Units.INCH);
            Assert.IsTrue(feet.CheckEquals(inch));
        }

        [Test]
        public void givenFeet_WhenEqualValues_ReturnsTrue()
        {
            QuantityMeasurements feet = new QuantityMeasurements(3.0, Units.FEET);
            QuantityMeasurements anotherFeet = new QuantityMeasurements(3.0, Units.FEET);
            Assert.IsTrue(feet.CheckEquals(anotherFeet));
        }

        [Test]
        public void givenFeetAndInch_WhenEqual_ReturnsTrue()
        {
            QuantityMeasurements feet = new QuantityMeasurements(1.0, Units.FEET);
            QuantityMeasurements inch = new QuantityMeasurements(12.0, Units.INCH);
            Assert.IsTrue(feet.CheckEquals(inch));
        }

        [Test]
        public void givenFeet_WhenNull_ReturnsFalse()
        {
            QuantityMeasurements feet = new QuantityMeasurements(1.0, Units.FEET);
            QuantityMeasurements anotherfeet = null;
            Assert.IsFalse(feet.Equals(anotherfeet));
        }

        [Test]
        public void givenFeet_WhenReferingToSame_ReturnsTrue()
        {
            QuantityMeasurements feet = new QuantityMeasurements(1.0, Units.FEET);
            QuantityMeasurements anotherFeet = feet;
            Assert.IsTrue(feet.Equals(anotherFeet));
        }

        [Test]
        public void givenInch_WhenNull_ReturnsFalse()
        {
            QuantityMeasurements inch = new QuantityMeasurements(1.0, Units.INCH);
            QuantityMeasurements anotherinch = null;
            Assert.IsFalse(inch.Equals(anotherinch));
        }

        [Test]
        public void givenInch_WhenReferingToSame_ReturnsTrue()
        {
            QuantityMeasurements Inch = new QuantityMeasurements(1.0, Units.INCH);
            QuantityMeasurements anotherInch = Inch;
            Assert.IsTrue(Inch.Equals(anotherInch));
        }

        [Test]
        public void givenInch_WhenEqualValues_ReturnsTrue()
        {
            QuantityMeasurements inch = new QuantityMeasurements(2.0, Units.INCH);
            QuantityMeasurements anotherinch = new QuantityMeasurements(2.0, Units.INCH);
            Assert.IsTrue(inch.CheckEquals(anotherinch));
        }

        [Test]
        public void givenInch_WhenNotEqualValues_ReturnsFalse()
        {
            QuantityMeasurements inch = new QuantityMeasurements(5.0, Units.INCH);
            QuantityMeasurements anotherinch = new QuantityMeasurements(2.0, Units.INCH);
            Assert.IsFalse(inch.CheckEquals(anotherinch));
        }

        [Test]
        public void givenThreeFeetAndOneYard_WhenToCompare_ReturnsTrue()
        {
            QuantityMeasurements feet = new QuantityMeasurements(3.0, Units.FEET);
            QuantityMeasurements yard = new QuantityMeasurements(1.0, Units.YARD);
            Assert.IsTrue(feet.CheckEquals(yard));
        }

        [Test]
        public void givenOneFeetAndOneYard_WhenToCompare_ReturnsFalse()
        {
            QuantityMeasurements feet = new QuantityMeasurements(3.0, Units.FEET);
            QuantityMeasurements anotherFeet = new QuantityMeasurements(1.0, Units.FEET);
            Assert.IsFalse(feet.CheckEquals(anotherFeet));
        }

        [Test]
        public void givenOneInchAndOneYard_WhenToCompare_ReturnsFalse()
        {
            QuantityMeasurements inch = new QuantityMeasurements(1.0, Units.INCH);
            QuantityMeasurements yard = new QuantityMeasurements(1.0, Units.YARD);
            Assert.IsFalse(inch.CheckEquals(yard));
        }


        [Test]
        public void givenThirtySixInchAndOneYard_WhenToCompare_ReturnsTrue()
        {
            QuantityMeasurements inch = new QuantityMeasurements(36.0, Units.INCH);
            QuantityMeasurements yard = new QuantityMeasurements(1.0, Units.YARD);
            Assert.IsTrue(inch.CheckEquals(yard));
        }

        [Test]
        public void givenOneYardAndThirtySixInch_WhenToCompare_ReturnsTrue()
        {
            QuantityMeasurements yard = new QuantityMeasurements(1.0, Units.YARD);
            QuantityMeasurements inch = new QuantityMeasurements(36.0, Units.INCH);
            Assert.IsTrue(yard.CheckEquals(inch));
        }

        [Test]
        public void givenOneYardAndThreeFeet_WhenToCompare_ReturnsTrue()
        {
            QuantityMeasurements yard = new QuantityMeasurements(1.0, Units.YARD);
            QuantityMeasurements feet = new QuantityMeasurements(3.0, Units.FEET);
            Assert.IsTrue(yard.CheckEquals(feet));
        }

        [Test]
        public void givenTwoInchAndFiveCentiMeter_WhenToCompare_ReturnsTrue()
        {
            QuantityMeasurements inch = new QuantityMeasurements(2.0, Units.INCH);
            QuantityMeasurements cm = new QuantityMeasurements(5.0, Units.CENTIMETER);
            Assert.IsTrue(cm.CheckEquals(inch));
        }

        [Test]
        public void givenInches_WhenAdded_ReturnsSum_InInches()
        {
            QuantityMeasurements quantityMeasurement1 = new QuantityMeasurements(2, Units.INCH);
            QuantityMeasurements quantityMeasurement = new QuantityMeasurements(2, Units.INCH);
            double sumInInches = quantityMeasurement.addQuantities(quantityMeasurement, quantityMeasurement1);
            Assert.AreEqual(4, sumInInches);
        }

    }
}