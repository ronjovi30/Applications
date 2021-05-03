using System;
using System.Collections.Generic;

namespace studentViolationRecordManagementSystem
{
        class Program
        {
        static void Main(string[] args)
        {
            //List
            //course
            List<string> course = new List<string>() { "BSA", "BSSE", "BSIE", "BSCE", "BSIT", };
            // BSA
            List<string> bsa1S1 = new List<string>() { "Lorena Currie", "Jaeden Curtis", "Kloe Gallegos", "Amiee Ayers", "Aalia Kane", "Riley-James Terry", "Soren Luna", "Charleigh Meyers", "Tia Dejesus", "Vikram Aguilar" };
            List<string> bsa2S1 = new List<string>() { "Aliyah Nash", "Jazmine Hodge", "Gabriel Benson", "Che Neal", "Sian Malone", "Grayson Mayer", "Donald O'Ryan", "Mert Chaney", "Esmay Norton", "Kimora Dickson", };
            List<string> bsa3S1 = new List<string>() { "Mila Stark", "Saxon Oakley", "Muneeb Crossley", "Tessa Mcfadden", "Katy Needham", "Kaylem Mcintyre", "Ayaan Manning", "Sahara Kirk", "Arman Odom", "Hilda Walmsley", };
            List<string> bsa4S1 = new List<string>() { "Janelle Nichols", "Riaan Garza", "Bronte Welch", "Cyrus Preston", "Sabah Mayer", "Shana Mack", "Leia Jenkins", "Margie Kaiser", "Jesus Colley", "Arda Davenport", };

            //BSA Number of Violation
            List<int> bsa1S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsa2S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsa3S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsa4S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

            // BSSE
            List<string> bsse1S1 = new List<string>() { "Raja Solomon", "Mercedes Beck", "Cain Cortez", "Annabelle Mathews", "Tyla Williams", "Lochlan Stewart", "Karter Sparks", "Emilie Sheehan", "Callen Nolan", "Sanjeev Brook", };
            List<string> bsse2S1 = new List<string>() { "Scarlett-Rose Terrell", "Lennon Romero", "Enrico English", "Simone Maddox", "Abdulrahman Greaves", "Misha Ramsey", "Marjorie Bowler", "Emeli Stout", "Carrie Drake", "Dillan Regan", };
            List<string> bsse3S1 = new List<string>() { "Leo Castaneda", "Tilly-Mae Neal", "Alya Luna", "Darcy Curtis", "Kalem Ellison", "Rylan Larsen", "Ahsan Gutierrez", "Clark Andrew", "Raheel O'Gallagher", "Ottilie Davies", };
            List<string> bsse4S1 = new List<string>() { "Emily Burris", "Manveer Hendricks", "Brandon Person", "Efa Hope", "Ayub Rivers", "Rebeca Enriquez", "Hughie Cherry", "Krishan Easton", "Sultan Edmonds", "Patrycja Fleming", };

            //BSSE Number of Violation

            List<int> bsse1S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsse2S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsse3S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsse4S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };


            // BSIE
            List<string> bsie1S1 = new List<string>() { "Ignacy Salgado", "Alivia Banks", "Kacey Irwin", "Jorja Fenton", "Kloe Hutchings", "Dolores Appleton", "Alyssia Edwards", "Ava-May Rojas", "Asiya Noel", "Hebe Jordan", };
            List<string> bsie2S1 = new List<string>() { "Kayne Marriott", "Arslan Sutton", "Kristofer Schroeder", "Haya Cummings", "Jaxson Whitley", "Kier Broadhurst", "Bernard Battle", "Poppie Colon", "Ameer Cohen", "Grant Ayers", };
            List<string> bsie3S1 = new List<string>() { "Abdurahman Burgess", "Carlton Bradley", "Carlton Bradley", "Elaine Mccray", "Kaitlan Cain", "Reiss Stott", "Hisham Emery", "Tyriq Wainwright", "Cole Knapp", "Sidra Trujillo", };
            List<string> bsie4S1 = new List<string>() { "Lloyd Sherman", "Joseph Ponce", "Sabrina Curry", "Wendy Adkins", "Franky Reynolds", "Evelyn Chavez", "Kaylem Mcintyre", "Isobella Norton", "Sahara Kirk", "Arman Odom", };

            //BSIE Number of Violation

            List<int> bsie1S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsie2S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsie3S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsie4S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

            // BSCE
            List<string> bsce1S1 = new List<string>() { "Harris Herrera", "Hilda Walmsley", "Janelle Nichols", "Riaan Garza", "Bronte Welch", "Cyrus Preston", "Sabah Mayer", "Leia Jenkins", "Margie Kaiser", "Jesus Colley", };
            List<string> bsce2S1 = new List<string>() { "Arda Davenport", "Raja Solomon", "Mercedes Beck", "Cain Cortez", "Annika Whitworth", "Annabelle Mathews", "Tyla Williams", "Lochlan Stewart", "Karter Sparks", "Emilie Sheehan", };
            List<string> bsce3S1 = new List<string>() { "Callen Nolan", "Sanjeev Brook", "Scarlett-Rose Terrell", "Neil O'Sullivan", "Lennon Romero", "Enrico English", "Simone Maddox", "Abdulrahman Greaves", "Misha Ramsey", "Marjorie Bowler", };
            List<string> bsce4S1 = new List<string>() { "Emeli Stout", "Carrie Drake", "Dillan Regan", "Leo Castaneda", "Tilly-Mae Neal", "Alya Luna", "Alya Luna", "Darcy Curtis", "Kalem Ellison", "Rylan Larsen", };

            //BSCE Number of Violation

            List<int> bsce1S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsce2S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsce3S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsce4S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

            // BSIT
            List<string> bsit1S1 = new List<string>() { "Ahsan Gutierrez", "Taliah Heath", "Clark Andrew", "Raheel O'Gallagher", "Ottilie Davies", "Emily Burris", "Manveer Hendricks", "Brandon Person", "Ayub Rivers", "Rebeca Enriquez", };
            List<string> bsit2S1 = new List<string>() { "Hughie Cherry", "Krishan Easton", "Sultan Edmonds", "Patrycja Fleming", "Ignacy Salgado", "Alivia Banks", "Kacey Irwin", "Jorja Fenton", "Kloe Hutchings", "Dolores Appleton", };
            List<string> bsit3S1 = new List<string>() { "Yaqub Nicholls", "Ho Hudson", "Alyssia Edwards", "Ava-May Rojas", "Asiya Noel", "Hebe Jordan", "Kayne Marriott", "Arslan Sutton", "Jaxson Whitley", "Bernard Battle", };
            List<string> bsit4S1 = new List<string>() { "Poppie Colon", "Ameer Cohen", "Grant Ayers", "Carlton Bradley", "Elaine Mccray", "Kaitlan Cain", "Reiss Stott", "Hisham Emery", "Tyriq Wainwright", "Sidra Trujillo", };

            //BSIT Number of Violation

            List<int> bsit1S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsit2S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsit3S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            List<int> bsit4S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };


            // Format
            Console.Title = "VIOLATION MANAGEMENT";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WindowHeight = 50;
            

            // code and conditions
            // securityFunction

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

            Console.WriteLine("\n\nWelcome STUDENT VIOlATION RECORD MANAGEMENT SYSTEM press a key to Continue.");
            Console.ReadKey();
            Console.Clear();

            int conExt = 0;

            for (; conExt != 1;)

            {
                // Exit
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |");
                Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
                Console.WriteLine("| |_____________________________________| |");
                Console.WriteLine("| |                                     | |\n\n\n");

                Console.WriteLine("(0) to Exit");
                Console.WriteLine("(1) to Continue\n");
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

                foreach (var courses in course)
                {
                    Console.WriteLine(courses);
                }
                Console.Write("\n\nChoose the Course:");
                String chosCourse = Console.ReadLine().ToUpper();
                Console.Write("\nYear:");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                //Condition
                if ((chosCourse == "BSA") && (year == 1))
                {
                    addViolation(year, chosCourse, bsa1S1, bsa1S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSA") && (year == 2))
                {
                    addViolation(year, chosCourse, bsa2S1, bsa2S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSA") && (year == 3))
                {
                    addViolation(year, chosCourse, bsa3S1, bsa2S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSA") && (year == 4))
                {
                    addViolation(year, chosCourse, bsa4S1, bsa4S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSSE") && (year == 1))
                {
                    addViolation(year, chosCourse, bsse1S1, bsse1S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSSE") && (year == 2))
                {
                    addViolation(year, chosCourse, bsse2S1, bsse2S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSSE") && (year == 3))
                {
                    addViolation(year, chosCourse, bsse3S1, bsse3S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSSE") && (year == 4))
                {
                    addViolation(year, chosCourse, bsse4S1, bsse4S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSIE") && (year == 1))
                {
                    addViolation(year, chosCourse, bsie1S1, bsie1S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSIE") && (year == 2))
                {
                    addViolation(year, chosCourse, bsie2S1, bsie2S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSIE") && (year == 3))
                {
                    addViolation(year, chosCourse, bsie3S1, bsie3S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSIE") && (year == 4))
                {
                    addViolation(year, chosCourse, bsie4S1, bsie4S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSCE") && (year == 1))
                {
                    addViolation(year, chosCourse, bsce1S1, bsce1S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSCE") && (year == 2))
                {
                    addViolation(year, chosCourse, bsce2S1, bsce2S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSCE") && (year == 3))
                {
                    addViolation(year, chosCourse, bsce3S1, bsce3S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSCE") && (year == 4))
                {
                    addViolation(year, chosCourse, bsce4S1, bsce4S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSIT") && (year == 1))
                {
                    addViolation(year, chosCourse, bsit1S1, bsit1S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSIT") && (year == 2))
                {
                    addViolation(year, chosCourse, bsit2S1, bsit2S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSIT") && (year == 3))
                {
                    addViolation(year, chosCourse, bsit3S1, bsit3S1N);
                    Console.Clear();
                    continue;
                }
                else if ((chosCourse == "BSIT") && (year == 4))
                {
                    addViolation(year, chosCourse, bsit4S1, bsit4S1N);
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("wrong input");
                    Console.ReadKey();
                    continue;
                }
            }



        }
        // Method That add violation to Student
        static int addViolation(int year, string course, List<string> secName, List<int> numberViolation)
        {
            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |");
            Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |\n\n");


            Console.WriteLine("(0) " + secName[0]);
            Console.WriteLine("(1) " + secName[1]);
            Console.WriteLine("(2) " + secName[2]);
            Console.WriteLine("(3) " + secName[3]);
            Console.WriteLine("(4) " + secName[4]);
            Console.WriteLine("(5) " + secName[5]);
            Console.WriteLine("(6) " + secName[6]);
            Console.WriteLine("(7) " + secName[7]);
            Console.WriteLine("(8) " + secName[8]);
            Console.WriteLine("(9) " + secName[9]);
            Console.WriteLine("\n\n");

            Console.WriteLine("note: type only the number correspond to that student\n");
            Console.Write("Choose a student:");
            int choosedName = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

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

            Console.WriteLine("Name:" + secName[choosedName]);
            Console.WriteLine("Course:" + course);
            Console.WriteLine("Year:" + year + "-1");
            // condition

            if (violation == "1")
            {

                Console.WriteLine("Violation: No ID");
                Console.WriteLine("Number of violation: " + numberViolation[choosedName] + 1);
            }
            else if (violation == "2")
            {

                Console.WriteLine("Violation: Improper Dressing ");
                Console.WriteLine("Number of violation: " + numberViolation[choosedName] + 1);
            }
            else if (violation == "3")
            {

                Console.WriteLine("Violation: Engaging in any unlawful Activity ");
                Console.WriteLine("Number of violation: " + numberViolation[choosedName] + 1);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            Console.ReadKey();
            return numberViolation[choosedName] + 1;

        }
    }
}


