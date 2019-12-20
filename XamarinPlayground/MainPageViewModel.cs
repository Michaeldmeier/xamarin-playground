using System;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinPlayground.calculator;

namespace XamarinPlayground
{
    public class MainPageViewModel : ViewModelBase
    {

        private ICalculationPipeline CalcPipeline;
        private ICalculator Calculator;


        public MainPageViewModel()
        {
            this.CalcPipeline = new CalculationPipeline();
            this.Calculator = new Calculator();
        }

        private string result = string.Empty;
        public string Result
        {
            get
            {
                return result;
            }
            private set
            {
                if (result != value)
                {
                    result = value;
                    Notify(nameof(Result));
                }
            }
        }

        private ICommand addNumberCommand;
        public ICommand AddNumberCommand
        {
            get
            {
                addNumberCommand = new Command<string>(NumberCommand);

                return addNumberCommand;
            }
        }

        private ICommand addOperatorCommand;
        public ICommand AddOperatorCommand
        {
            get
            {
                addOperatorCommand = new Command<string>(OperationCommand);

                return addOperatorCommand;
            }
        }

        private void NumberCommand(string args)
        {
            Double res = 0;
            if (this.result != "") {
                res = Convert.ToDouble(this.result) + Convert.ToDouble(args);
            }
            
            this.result = Convert.ToString(res);
          
        }


        private void OperationCommand(string args)
        {

            switch (args)
            {
                case "c":
                    this.result = "0";
                    break;
                case "+":

                    double number = Convert.ToDouble(args);
                    CalcPipeline.Add(Operation.Plus, number);

                    break;
                case "=":

                    double numberLast = Convert.ToDouble(args);

                 
                    // Store Result
                    this.result = Convert.ToString(result);

                    break;
            }

        }

      
    }
}
