using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPR2
{
    public class _4method
    {
        public static double ADD(double first, double second)
        {
            return first + second;
        }
        public static double SUB(double first, double second)
        {
            return first - second;
        }
        public static double DIV(double first, double second)
        {
            return first==0 ? 0 : second==0? 0 : first / second;
        }
        
        public static double MUL(double first, double second)
        {
            return first * second;
        }
    }
}
