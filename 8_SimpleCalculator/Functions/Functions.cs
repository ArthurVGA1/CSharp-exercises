using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator_CSharp.Functions
{
    internal class Functions
    {
        public double Sum(double x, double y)
        {
            double sum = x + y;

            return sum;
        }

        public double Subtract(double x, double y)
        {
            double subtract = x - y;

            return subtract;
        }

        public double Multiply(double x, double y)
        {
            double multiply = x * y;

            return multiply;
        }

        public double Divide(double x, double y)
        {
            double divide = x / y;

            return divide;
        }

        public double Potency(int x, int y)
        {
            double pow = Math.Pow(x, y);

            return pow;
        }

        public double SquareRoot(double x)
        {
            double sqrt = Math.Sqrt(x);

            return sqrt;
        }
    }
}
