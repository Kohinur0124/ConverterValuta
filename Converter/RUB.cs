using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public  class RUB
    {
        public static double CourseUZS { set; get; } = 136.53;

        public static double CourseEUR { set; get; } = 0.011;

        public static double CourseUSD { set; get; } = 0.012;

        public static void ToUZS(double rub)
        {
            Console.WriteLine($"{rub} RUBL = {rub * CourseUZS} so`m");
        }

        public static void ToEUR(double rub)
        {
            Console.WriteLine($"{rub} RUBL = {rub * CourseEUR} EUR");
        }

        public static void ToUSD(double rub)
        {
            Console.WriteLine($"{rub} RUBL = {rub * CourseUSD} $");
        }
    }
}
