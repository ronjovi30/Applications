using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class addViolation

    {

        public int addingViolation(string studentName, string studentCourse, int numberViolation)
        {
            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |");
            Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |\n\n\n");

            Console.Write("\nPosible Violation\n1. no ID\n2. improper dressing\n3. engaging in any unlawful Activity\n\n\nnote: type only the number correspoding to the violation.\n\n");
            Console.Write("Violation: ");
            String violation = Console.ReadLine();

            Console.WriteLine("\n\n\nVoilation has been added\n");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |");
            Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |\n\n\n");

            Console.WriteLine("Name:" + studentName);
            Console.WriteLine("Course:" + studentCourse);

            // condition

            if (violation == "1")
            {

                Console.WriteLine("Violation: No ID");
                Console.WriteLine("Number of violation: " + numberViolation + 1);

            }
            else if (violation == "2")
            {

                Console.WriteLine("Violation: Improper Dressing ");
                Console.WriteLine("Number of violation: " + numberViolation + 1);

            }
            else if (violation == "3")
            {

                Console.WriteLine("Violation: Engaging in any unlawful Activity ");
                Console.WriteLine("Number of violation: " + numberViolation + 1);

            }
            else
            {
                Console.WriteLine("invalid input");
            }
            Console.ReadKey();
            return numberViolation + 1;

        }


    }
}
