using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public  class EUR
    {
        public static double CourseUZS { set; get; } = 12553.31;

        public static double CourseUSD { set; get; } = 1.09;

        public static double CourseRUB { set; get; } = 91.94;

        public static void ToUZS(double eur)
        {
            Console.WriteLine($"{eur} EUR = {eur * CourseUZS} so`m");
        }

        public static void ToUSD(double eur)
        {
            Console.WriteLine($"{eur} EUR = {eur * CourseUSD} $");
        }

        public static void ToRUB(double eur)
        {
            Console.WriteLine($"{eur} EUR = {eur * CourseRUB} RUBL");
        }
    }
}
