using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Regex rx = new Regex(@"<\[[^a-zA-Z0-9]*\]\.{1}(?:\.\[[a-zA-Z0-9]*\]\.)*");

            string input = Console.ReadLine();
            while (input!="Traincode!")
            {
                Match m = rx.Match(input);

                if (m.Success && input==m.Groups[0].Value)
                {
                    list.Add(input);
                }

                input = Console.ReadLine();
            }

            foreach (string train in list)
            {
                Console.WriteLine(train);
            }
        }
    }
}
