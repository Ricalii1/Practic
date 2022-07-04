using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2MVP
{
    class Model
    {
        public double a, b;
        public string label1;

        public string Equal(int x, int y)
        {
            
            a = x;
            b = y;
            switch (label1)
            {
                case "+":
                    return Convert.ToString(a + b);
                case "-":
                    return Convert.ToString(a - b);
                case "*":
                    return Convert.ToString(a * b);
                case "/":
                    return a != 0 ? Convert.ToString(a / b) : "Нельзя делить на 0";
                default:
                    return "Недопустимое значение";
            }

        }
    }
}
