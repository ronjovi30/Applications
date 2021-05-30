using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using ConsoleApp2;

namespace studentViolationRecordManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Form
            Console.Title = "STUDENT VIOLATION MANAGEMENT";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowHeight = 40;
            Console.WindowWidth = 80;
            Console.Write("Enter any Key");
            Console.ReadKey();
            Console.Clear();
            //Security
            int security = 3;
            for (; security != 1;)
            {
                Console.WriteLine("\nSECURITY");
                Console.Write("\n\n\n\nUsername:");
                string user = Console.ReadLine();
                Console.Write("\nPassword:");
                string pass = Console.ReadLine();

                if ((user == "red123") && (pass == "password"))
                {
                    break;
                }
                else if ((user != "red123") && (pass == "password"))
                {
                    Console.WriteLine("\n\nthe username are wrong");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if ((user == "red123") && (pass != "password"))
                {
                    Console.WriteLine("\n\nthe password are wrong");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("\n\nthe username and password are wrong");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
            // choose option
            Console.WriteLine("\n\nWelcome STUDENT VIOlATION RECORD MANAGEMENT SYSTEM press a key to Continue.");
            Console.ReadKey();
            Console.Clear();
            studentData1 data = new studentData1();
            addViolation violation = new addViolation();
            search searchfunction = new search();
            int conExt = 0;

            for (; conExt != 1;)

            {
                // Exit
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |");
                Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |\n\n\n");



                Console.WriteLine("(1) Add Violation\n");
                Console.WriteLine("(2) Search \n");
                Console.WriteLine("(0) to Exit \n");
                Console.Write("Enter number:");

                string answer = Console.ReadLine();

                if (answer == "0")
                {
                    break;
                }
                else if (answer == "1")
                {
                    Console.Clear();
                }
                else if (answer == "2")
                {
                    Console.Clear();
                    searchfunction.searchFunction(data.course, data.bsa1S1, data.bsa2S1, data.bsa3S1, data.bsa4S1, data.bsa1S1N, data.bsa2S1N, data.bsa3S1N, data.bsa4S1N);
                    continue;
                }
                else
                {
                    Console.WriteLine("wrong input try again.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                // addViolationFunction
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |");
                Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |\n\n\n");




                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Clear();
                //BSA
                if (data.bsa1S1.Contains(name))
                {

                    violation.addingViolation(data.bsa1S1[data.bsa1S1.IndexOf(name)], data.course[1], data.bsa1S1N[data.bsa1S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsa2S1.Contains(name))
                {

                    violation.addingViolation(data.bsa2S1[data.bsa2S1.IndexOf(name)], data.course[1], data.bsa2S1N[data.bsa2S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsa3S1.Contains(name))
                {

                    violation.addingViolation(data.bsa3S1[data.bsa3S1.IndexOf(name)], data.course[1], data.bsa3S1N[data.bsa3S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsa4S1.Contains(name))
                {

                    violation.addingViolation(data.bsa4S1[data.bsa4S1.IndexOf(name)], data.course[1], data.bsa4S1N[data.bsa4S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                // BSSE
                else if (data.bsse1S1.Contains(name))
                {

                    violation.addingViolation(data.bsse1S1[data.bsse1S1.IndexOf(name)], data.course[2], data.bsse1S1N[data.bsse1S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsse2S1.Contains(name))
                {

                    violation.addingViolation(data.bsse2S1[data.bsse2S1.IndexOf(name)], data.course[2], data.bsse2S1N[data.bsse2S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsse3S1.Contains(name))
                {

                    violation.addingViolation(data.bsse3S1[data.bsse3S1.IndexOf(name)], data.course[2], data.bsse3S1N[data.bsse3S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsse4S1.Contains(name))
                {

                    violation.addingViolation(data.bsse4S1[data.bsse4S1.IndexOf(name)], data.course[2], data.bsse4S1N[data.bsse4S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                // BSIE
                else if (data.bsie1S1.Contains(name))
                {

                    violation.addingViolation(data.bsie1S1[data.bsie1S1.IndexOf(name)], data.course[3], data.bsie1S1N[data.bsie1S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsie2S1.Contains(name))
                {

                    violation.addingViolation(data.bsie2S1[data.bsie2S1.IndexOf(name)], data.course[3], data.bsie2S1N[data.bsie2S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsie3S1.Contains(name))
                {

                    violation.addingViolation(data.bsie3S1[data.bsie3S1.IndexOf(name)], data.course[3], data.bsie3S1N[data.bsie3S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsie4S1.Contains(name))
                {

                    violation.addingViolation(data.bsie4S1[data.bsie4S1.IndexOf(name)], data.course[3], data.bsie4S1N[data.bsie4S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                //BSCE
                else if (data.bsce1S1.Contains(name))
                {

                    violation.addingViolation(data.bsce1S1[data.bsce1S1.IndexOf(name)], data.course[4], data.bsce1S1N[data.bsce1S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsce2S1.Contains(name))
                {

                    violation.addingViolation(data.bsce2S1[data.bsce2S1.IndexOf(name)], data.course[4], data.bsce2S1N[data.bsce2S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsce3S1.Contains(name))
                {

                    violation.addingViolation(data.bsce3S1[data.bsce3S1.IndexOf(name)], data.course[4], data.bsce3S1N[data.bsce3S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsce4S1.Contains(name))
                {

                    violation.addingViolation(data.bsce4S1[data.bsce4S1.IndexOf(name)], data.course[4], data.bsce4S1N[data.bsce4S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                //BSIT
                else if (data.bsit1S1.Contains(name))
                {

                    violation.addingViolation(data.bsit1S1[data.bsit1S1.IndexOf(name)], data.course[5], data.bsit1S1N[data.bsit1S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsit2S1.Contains(name))
                {

                    violation.addingViolation(data.bsit2S1[data.bsit2S1.IndexOf(name)], data.course[5], data.bsit2S1N[data.bsit2S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsit3S1.Contains(name))
                {

                    violation.addingViolation(data.bsit3S1[data.bsit3S1.IndexOf(name)], data.course[5], data.bsit3S1N[data.bsit3S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (data.bsit4S1.Contains(name))
                {

                    violation.addingViolation(data.bsit4S1[data.bsit4S1.IndexOf(name)], data.course[5], data.bsit4S1N[data.bsit4S1.IndexOf(name)]);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("Name is no found");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
            // search for student info
            // add violation



        }
    }
}
