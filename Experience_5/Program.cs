using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experience_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the deposit amount: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            double percent = 0;
            if (sum < 100)
            {
                percent = 0.05;
            }
            else if (sum <= 200)
            {
                percent = 0.07;
            }
            else
            {
                percent = 0.1;
            }
            sum += sum * percent + 15;

            Console.WriteLine($"The amount of the deposit after interest accrual: {sum}");

            Console.ReadKey();
        }
    }
}
