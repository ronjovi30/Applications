using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class search
    {
        public void searchFunction(List<string> course, List<string> bsa1S1, List<string> bsa2S1, List<string> bsa3S1, List<string> bsa4S1, List<int> bsa1S1N, List<int> bsa2S1N, List<int> bsa3S1N, List<int> bsa4S1N)
        {
            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |");
            Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |\n\n\n");

            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Clear();
            //BSA
            if (bsa1S1.Contains(name))
            {
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |");
                Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |\n\n\n");

                Console.WriteLine("Name: " + bsa1S1[bsa1S1.IndexOf(name)]);
                Console.WriteLine("Course: " + course[1]);
                Console.WriteLine("Number of Violation: " + bsa1S1N[bsa1S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
            }
            else if (bsa2S1.Contains(name))
            {
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |");
                Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |\n\n\n");

                Console.WriteLine("Name: " + bsa2S1[bsa2S1.IndexOf(name)]);
                Console.WriteLine("Course: " + course[1]);
                Console.WriteLine("Number of Violation: " + bsa2S1N[bsa2S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
            }
            else if (bsa3S1.Contains(name))
            {
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |");
                Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |\n\n\n");

                Console.WriteLine("Name: " + bsa3S1[bsa3S1.IndexOf(name)]);
                Console.WriteLine("Course: " + course[1]);
                Console.WriteLine("Number of Violation: " + bsa3S1N[bsa3S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
            }
            else if (bsa4S1.Contains(name))
            {
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |");
                Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |\n\n\n");

                Console.WriteLine("Name: " + bsa4S1[bsa4S1.IndexOf(name)]);
                Console.WriteLine("Course: " + course[1]);
                Console.WriteLine("Number of Violation: " + bsa4S1N[bsa4S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Name is not found.");
                Console.Clear();
            }
        }
    }
}