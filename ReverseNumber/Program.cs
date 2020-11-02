using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number within 10 - 9999 range: ");

                string input = Console.ReadLine();

                int num;

                int.TryParse(input, out num);

                if (num == 10 || num <= 99)
                {
                    int num_1 = num % 10;
                    int num_2 = num / 10;
                    Console.WriteLine($"Initial number: {num}\nReverse number: {num_1}{num_2}");
                }
                else if (num == 100 || num <= 999)
                {
                    int num_1 = num % 10;
                    int num_2 = (num / 10) % 10;
                    int num_3 = num / 100;
                    Console.WriteLine($"Initial number: {num}\nReverse number: {num_1}{num_2}{num_3}");
                }
                else
                {
                    int num_1 = num % 10;
                    int num_2 = (num % 100) / 10;
                    int num_3 = (num / 100) % 10;
                    int num_4 = num / 1000;
                    Console.WriteLine($"Initial number: {num}\nReverse number: {num_1}{num_2}{num_3}{num_4}");
                }

                Console.ReadLine();
            }
        }
    }
}
