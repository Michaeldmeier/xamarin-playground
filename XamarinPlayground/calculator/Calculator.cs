using System;
namespace XamarinPlayground.calculator
{
    public class Calculator : ICalculator
    {
        public Calculator()
        {
        }

        Double ICalculator.Sum(Double[] numbers)
        {
            Double result = 0;

            foreach (Double n in numbers)
            {
                result += n;
            }

            return result;
        }

        Double ICalculator.Sum(Double n1, Double n2)
        {
            return n1 + n2;
        }
    }
}
