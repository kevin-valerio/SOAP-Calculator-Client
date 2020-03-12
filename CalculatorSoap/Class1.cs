using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using CalculatorSoap.ServiceReference1;

namespace CalculatorSoapLibrary
{
    public class CalculatorSoapDLL
    {
        private CalculatorSoapClient calculatr = new CalculatorSoapClient();

        public int Add(int a, int b) {
            return calculatr.Add(a, b);
        }

        public int Subtract(int a, int b) {
            return calculatr.Subtract(a, b);
        }

        public int Multiply(int a, int b) {
            return calculatr.Multiply(a, b);
        }


        public int Divide(int a, int b) {
            return calculatr.Divide(a, b);
        }

    }
}
