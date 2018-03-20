// CONFIRMED from PepiBobanov

using System;
// removed unnecesary libraryes

namespace Problem2
{
    class Problem2
    {
        static void Main(string[] args)
        {
			// use double to avoid float overflow
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double a = Math.Round(width * height, 2);

			// moje i taka: Console.WriteLine($"{area:0.00}");
            Console.WriteLine(String.Format("{0:0.00}", a));
			
        }
    }
}
