// WeightHelper.cs
using System;

namespace MyWeightHelperApp.Models
{
    public static class WeightHelper
    {
        public static double CalculateBMI(double height, double weight)
        {
            if (height == 0 || weight == 0)
            {
                return double.NaN;
            }

            return weight / Math.Pow(height / 100, 2);
        }



        public static string GetCategory(double height, double weight)
        {
            if (height == 0 || weight == 0)
            {
                return "Underweight";
            }

            double bmi = CalculateBMI(height, weight);
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi < 25)
            {
                return "Normal weight";
            }
            else if (bmi < 30)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }
    }
}
