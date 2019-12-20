using System;
using System.Collections.Generic;

namespace XamarinPlayground.calculator
{
    public interface ICalculationPipeline
    {
        void Add(Operation operation,  Double number);
        Dictionary<Operation, Double> GetQueue();
        Double Calculate();
        void Clear();
    }
}
