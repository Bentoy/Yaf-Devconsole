using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevConsole
{
    public class MathFunctions
    {
        public int[] OrderAscending(int[] numbers)
        {
            int[] ordered = new int[6];

            Console.WriteLine("Unordered list");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            for (int index = 0; index < numbers.Length; index++)
            {
                int next = index + 1;
                if (next == numbers.Length)
                    continue;

                if (numbers[index] > numbers[index + 1])
                {
                    int temp = numbers[index];
                    numbers[index] = numbers[index + 1];
                    numbers[index + 1] = temp;
                }
            }

            Console.WriteLine("\nFirst iteration list");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            return ordered;
        }
    }
}
