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

        [Test]
        public void givenSingleInch_WhenForAddition_ReturnsSum_InInches()
        {
            QuantityMeasurements quantityMeasurement1 = new QuantityMeasurements(2, Units.INCH);
            double sumInInches = quantityMeasurement1.addQuantities(quantityMeasurement1);
            Assert.AreEqual(2, sumInInches);
        }


        [Test]
        public void givenNoQuantities_WhenForAddition_ReturnsZero()
        {
            QuantityMeasurements quantityMeasurement1 = new QuantityMeasurements(2, Units.INCH);
            double sumInInches = quantityMeasurement1.addQuantities();
            Assert.AreEqual(0, sumInInches);
        }

        [Test]
        public void givenOneFeet_AndTwoInch_WhenAdded_ReturnsSum_InInches()
        {
            QuantityMeasurements quantityMeasurement1 = new QuantityMeasurements(1, Units.FEET);
            QuantityMeasurements quantityMeasurement = new QuantityMeasurements(2, Units.INCH);
            double sumInInches = quantityMeasurement.addQuantities(quantityMeasurement, quantityMeasurement1);
            Assert.AreEqual(14, sumInInches);
        }

        [Test]
        public void givenFeets_WhenAdded_ReturnsSum_InInches()
        {
            QuantityMeasurements quantityMeasurement1 = new QuantityMeasurements(1, Units.FEET);
            QuantityMeasurements quantityMeasurement = new QuantityMeasurements(1, Units.FEET);
            double sumInInches = quantityMeasurement.addQuantities(quantityMeasurement, quantityMeasurement1);
            Assert.AreEqual(24, sumInInches);
        }

        [Test]
        public void givenInch_AndCentiMeter_WhenAdded_ReturnsSum_InInches()
        {
            QuantityMeasurements quantityMeasurement1 = new QuantityMeasurements(2, Units.INCH);
            QuantityMeasurements quantityMeasurement = new QuantityMeasurements(2.5, Units.CENTIMETER);
            double sumInInches = quantityMeasurement.addQuantities(quantityMeasurement, quantityMeasurement1);
            Assert.AreEqual(3, sumInInches);
        }

        [Test]
        public void givenOneGallon_AndRespectiveLitres_WhenCompared_ReturnsTrue()
        {
            QuantityMeasurements quantityMeasurement1 = new QuantityMeasurements(1, Units.GALLON);
            QuantityMeasurements quantityMeasurement = new QuantityMeasurements(3.78, Units.LITRE);
            Assert.IsTrue(quantityMeasurement.CheckEquals(quantityMeasurement1));
        }

        [Test]
        public void givenOneLitre_AndThousandMiliLitre_WhenCompared_ReturnsTrue()
        {
            QuantityMeasurements quantityMeasurement1 = new QuantityMeasurements(1, Units.LITRE);
            QuantityMeasurements quantityMeasurement = new QuantityMeasurements(1000, Units.MILILITRE);
            Assert.IsTrue(quantityMeasurement1.CheckEquals(quantityMeasurement));
        }

        [Test]
        public void givenOneGallon_AndThreeThousandSevenHunderedAndEightyMiliLitre_WhenCompared_ReturnsTrue()
        {
            QuantityMeasurements quantityMeasurement1 = new QuantityMeasurements(3780, Units.MILILITRE);
            QuantityMeasurements quantityMeasurement = new QuantityMeasurements(1, Units.GALLON);
            Assert.IsTrue(quantityMeasurement1.CheckEquals(quantityMeasurement));
        }

        [Test]
        public void givenGallonAndLitres_WhenForAddition_ReturnsSumInLitres()
        {
            QuantityMeasurements quantityMeasurement1 = new QuantityMeasurements(1, Units.GALLON);
            QuantityMeasurements quantityMeasurement = new QuantityMeasurements(3.78, Units.LITRE);
            double sumInLitres = quantityMeasurement.addQuantities(quantityMeasurement, quantityMeasurement1);
            Assert.AreEqual(7560.0d, sumInLitres);
        }

        [Test]
        public void givenOneLitreAndOneThousandMiliLitres_WhenForAddition_ReturnsSumInLitres()
        {
            QuantityMeasurements quantityMeasurement1 = new QuantityMeasurements(1, Units.LITRE);
            QuantityMeasurements quantityMeasurement = new QuantityMeasurements(1000, Units.MILILITRE);
            double sumInLitres = quantityMeasurement.addQuantities(quantityMeasurement, quantityMeasurement1);
            Assert.AreEqual(2000, sumInLitres);
        }

        [Test]
        public void givenOneKiloGram_And1000Grams_WhenCompared_ReturnsTrue()
        {
            QuantityMeasurements quantityMeasurement1 = new QuantityMeasurements(1, Units.KILOGRAM);
            QuantityMeasurements quantityMeasurement = new QuantityMeasurements(1000, Units.GRAMS);
            Assert.IsTrue(quantityMeasurement.CheckEquals(quantityMeasurement1));
        }

        [Test]
        public void givenOneTon_And1000KiloGram_WhenCompared_ReturnsTrue()
        {
            QuantityMeasurements quantityMeasurement1 = new QuantityMeasurements(1, Units.TONNE);
            QuantityMeasurements quantityMeasurement = new QuantityMeasurements(1000, Units.KILOGRAM);
            Assert.IsTrue(quantityMeasurement.CheckEquals(quantityMeasurement1));
        }
    }
}