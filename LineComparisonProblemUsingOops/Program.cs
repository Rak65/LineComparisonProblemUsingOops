using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblemUsingOops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateLength calculateLength = new CalculateLength();
            calculateLength.EqualTwoLine();
            Console.ReadKey();
        }
    }
}
