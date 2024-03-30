using Xunit;
using MyWeightHelperApp.Models;

namespace MyWeightHelperApp.Tests
{
    public class TestWeightHelper
    {
        [Theory]
        [InlineData(170, 70, 24.22, "Normal weight")] // Typical valid input
        [InlineData(0, 70, double.NaN, "Underweight")] // Zero height
        [InlineData(170, 0, double.NaN, "Underweight")] // Zero weight
        [InlineData(0, 0, double.NaN, "Underweight")] // Zero height and weight
        [InlineData(150, 40, 17.78, "Underweight")] // Minimum valid values (BVA)
        [InlineData(200, 150, 37.5, "Obese")] // Maximum valid values (BVA)
        public void TestCalculateBMI(double height, double weight, double expectedBMI, string expectedCategory)
        {
            // Arrange

            // Act
            double actualBMI = WeightHelper.CalculateBMI(height, weight);
            string actualCategory = WeightHelper.GetCategory(height, weight);

            // Assert
            Assert.Equal(expectedBMI, actualBMI, 2); // Check BMI with 2 decimal places precision
            Assert.Equal(expectedCategory, actualCategory);
        }
    }
}
