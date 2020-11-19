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
        public void givenFeet_WhenEqual_ReturnsTrue()
        {
            QuantityMeasurements feet = new QuantityMeasurements(0.0, Units.FEET);
            QuantityMeasurements inch = new QuantityMeasurements(0.0, Units.FEET);
            Assert.IsTrue(feet.CheckEquals(inch));
        }
    }
}