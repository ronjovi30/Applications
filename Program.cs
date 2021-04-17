using System;

namespace studentViolationRecordManagementSystem
{
        class Program
        {
            static void Main(string[] args)
            {
                // Appearance 
                Console.Title = "VIOLATION MANAGEMENT";
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WindowHeight = 50;
                Console.WriteLine("Welcome");
                Console.ReadKey();
                Console.WriteLine("STUDENT VIOlATION RECORD MANAGEMENT\n\n\n");

                // variables

                int numberViolation = 0;
                int final;
                //funtion

                // addFuntion
                Console.WriteLine("Available Course");
                Console.WriteLine("BEED,BSIT,BSA,BSBA,BSIE");
                Console.Write("Course: ");
                String course = Console.ReadLine().ToUpper();
                Console.Write("Year: ");
                String year = Console.ReadLine();

                Console.Write("Section: ");
                String section = Console.ReadLine();

                Console.Write("Violators Name:");
                String name = Console.ReadLine();

                Console.Write("\nPosible Violation\n1. no ID\n2. improper dressing\n3. engaging in any unlawful Activity\n\n\nnote: type only the number correspoding to the violation.\n\n");

                Console.Write("Violation: ");
                String violation = Console.ReadLine();

                Console.WriteLine("\n\n\nVoilation has been added\n");
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Course:" + course);
                Console.WriteLine("Year:" + year);
                Console.WriteLine("Section:" + section);
                Console.WriteLine(" Violation" + violation);

                // condition
                if (violation == "1")
                {
                    final = numberViolation + 1;
                    Console.WriteLine(" Violation: No ID");
                    Console.WriteLine("Number of violation: " + final);
                }
                else if (violation == "2")
                {
                    final = numberViolation + 1;
                    Console.WriteLine(" Violation: Improper Dressing ");
                    Console.WriteLine("Number of violation: " + final);
                }
                else if (violation == "3")
                {
                    final = numberViolation + 1;
                    Console.WriteLine(" Violation: Engaging in any unlawful Activity ");
                    Console.WriteLine("Number of violation: " + final);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }

                Console.ReadKey();
            }
        }
    }
