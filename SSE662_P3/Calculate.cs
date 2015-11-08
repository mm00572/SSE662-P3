using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE662_P3
{
    public class Calculate
    {
        const string PLUS = "+";
        const string MINUS = "-";
        const string TIMES = "*";
        const string DIVIDE = "/";

        public static double Compute(string operand, double operator1, double operator2)
        {        
            double result = 0.0;

            switch(operand)
            {
                case PLUS:
                    result = operator1 + operator2;
                    break;
                case MINUS:
                    result = operator1 - operator2;
                    break;
                case TIMES:
                    result = operator1 * operator2;
                    break;
                case DIVIDE:
                    result = operator1 / operator2;
                    break;
            }

            return result;
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
