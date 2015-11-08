using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE662_P3
{
    public class Calculate
    {
        public static double Compute(string operand, double operator1, double operator2)
        {
            double result = 0.0;

            switch(operand)
            {
                case "+":
                    result = operator1 + operator2;
                    break;
                case "-":
                    result = operator1 - operator2;
                    break;
                case "*":
                    result = operator1 * operator2;
                    break;
                case "/":
                    result = operator1 / operator2;
                    break;
            }

            return result;
        }
    }
}
