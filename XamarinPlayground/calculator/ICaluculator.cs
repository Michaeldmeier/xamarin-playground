using System;
namespace XamarinPlayground.calculator
{
    public interface ICalculator
    {
        Double Sum(Double[] numbers);
        Double Sum(Double n1, Double n2);
    }
}
