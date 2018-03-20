using System;

namespace Problem2
{
    class Problem2
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = Math.Round(width * height, 2);

            Console.WriteLine(String.Format("{0:0.00}", area));
        }
    }
}
