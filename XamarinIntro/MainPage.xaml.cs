using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinIntro
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        String resultView = "0";

        enum Operations { Plus, Minus, Mulitply, Divide, PlusMinus };

        Operations operation;

        List<double> numberCache = new List<double>();

        public MainPage()
        {
            InitializeComponent();

        }

        public void btn_clicked(object sender, EventArgs args)
        {
            Button caller = (Button)sender;

            // Add number to cache
            this.resultView += caller.Text;
            lbl_result.Text = resultView;
        }


        public void btn_action_clicked(object sender, EventArgs args)
        {
            Button caller = (Button)sender;
            String callerOps = (String)caller.Text.ToLower();

            switch (callerOps) {
                case "c":
                    this.resultView = "0";
                    break;
                case "+":
                    double number = Convert.ToDouble(this.resultView);
                    numberCache.Add(number);
                    this.operation = Operations.Plus;
                    break;
                case "=":

                    double numberLast = Convert.ToDouble(this.resultView);
                    numberCache.Add(numberLast);

                    double result = 0;

                    // Calculate
                    switch (operation) {
                        case Operations.Plus:
                            foreach (double n in numberCache) {
                                result += n;
                            }
                            break;
                        default:
                            break;
                    }

                    // Store Result
                    this.resultView = Convert.ToString(result);

                    break;
            }


            lbl_result.Text = resultView;
        }
    }


}
