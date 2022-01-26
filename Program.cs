using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter A:");
                var A = Console.ReadLine().Split(' ').Distinct();

                Console.WriteLine("Enter B:");
                var B = Console.ReadLine().Split(' ').Distinct();

                var U = A.Union(B);

                int command = 0;
                while (command < 1 || command > 5)
                {
                    Console.WriteLine("Select Operation :");
                    Console.WriteLine(" 1 - difference");
                    Console.WriteLine(" 2 - Union");
                    Console.WriteLine(" 3 - Intersection");
                    Console.WriteLine(" 4 - symmetric difference");
                    Console.WriteLine(" 5 - negation");
                    command = Int32.Parse(Console.ReadLine());
                }

                IEnumerable<string> R;
                if (command == 1) { R = A.Except(B); }
                else if (command == 2) { R = A.Union(B); }
                else if (command == 3) { R = A.Intersect(B); }
                else if (command == 4) { R = A.Except(B).Union(B.Except(A)); }
                else { R = U.Except(A); }

                Console.WriteLine("Result:");
                foreach (var i in R)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
                Console.WriteLine("===============");
            }
        }
    }
}
