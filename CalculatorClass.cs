using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{

    public delegate T information<T>(T args, T arg1);

    internal class CalculatorClass
    {
        public information<String> Information;

        public Double GetSum(double num1, double num2) { 
            return num1 + num2;
        }

        public Double GetDifference(double num1, double num2) { 
            return num1 - num2;
        }

        public Double GetProduct(double num1, double num2) { 
            return num1 * num1;
        }

        public Double GetQuitient(double num1, double num2) { 
            return num1 / num2;
        }

        public event information<double> CalculateEvent
        {
            add {
                Console.WriteLine("Added the Delegate" + value);
            }
            remove {
                Console.WriteLine("Remove the Delegate" + value);
            }
        }



    }
}
