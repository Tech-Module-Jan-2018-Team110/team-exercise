using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
			//We receive 4 integer from the console
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

			//Print the integers on the console in 4-digit debit card format
            Console.WriteLine($"{a:D4} {b:D4} {c:D4} {d:D4}");
        }
    }
}
