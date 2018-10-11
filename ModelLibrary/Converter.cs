using System;

namespace ModelLibrary
{
    public class Converter
    {
        private const double Gram = 0.0352739619;
        private const double Ounces = 28.3495231;

        public static double GramToOunces(double ounces)
        {
            return Gram * ounces;
        }

        public static double OuncesToGram(double gram)
        {
            return Ounces * gram;
        }
    }
}