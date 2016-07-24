using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            MathFunctions function = new MathFunctions();
            function.OrderAscending(new int[] { 1, 10, 7, 3, 9, 11 });


            Console.ReadLine();
        }
    }
}
