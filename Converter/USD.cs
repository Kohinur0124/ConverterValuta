using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public  class USD
    {
        public static double CourseUZS { set; get; } = 11498.69;

        public static double CourseEUR { set; get; } = 0.92;

        public static double CourseRUB { set; get; } = 84.21;

        public static void ToUZS(double usd)
        {
            Console.WriteLine($"{usd} $ = {usd * CourseUZS} so`m");
        }

        public static void ToEUR(double uzs)
        {
            Console.WriteLine($"{uzs} $ = {uzs * CourseEUR} EUR");
        }

        public static void ToRUB(double usd)
        {
            Console.WriteLine($"{usd} $ = {usd * CourseRUB} =RUBL");
        }
    }
}
