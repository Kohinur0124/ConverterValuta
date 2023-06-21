using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public  class UZS
    {
        public static double CourseUSD { set; get; } = 0.000087;

        public static double CourseEUR { set; get; } = 0.00008;

        public static double CourseRUB { set; get; } = 0.0073;

        public static void ToUSD(double uzs)
        {
            Console.WriteLine($"{uzs} so`m = {(uzs * CourseUSD)} $");
        }

        public static void ToEUR(double uzs)
        {
            Console.WriteLine($"{uzs} so`m = {uzs * CourseEUR} EUR ");
        }
       
        public static void ToRUB(double uzs)
        {
            Console.WriteLine($"{uzs} so`m = {uzs * CourseRUB} RUBL");
        }
    }
}
