using System;
using System.Collections.Generic;

namespace XamarinPlayground.calculator
{
    public class CalculationPipeline : ICalculationPipeline
    {

        private Dictionary<Operation, Double> Pipeline;

        public CalculationPipeline()
        {
        }

        public void Add(Operation operation, double number)
        {
            Pipeline.Add(operation, number);
        }

        public double Calculate()
        {
            // TODO: Implement Calculate
            return 5;
        }

        public void Clear()
        {
            Pipeline.Clear();
        }

        public Dictionary<Operation, Double> GetQueue()
        {
            return Pipeline;
        }
    }
}
