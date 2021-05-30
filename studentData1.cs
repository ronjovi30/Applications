using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class studentData1
    {
        //List
        //course
        public List<string> course = new List<string>() { "BSA", "BSSE", "BSIE", "BSCE", "BSIT", };
        // BSA
        public List<string> bsa1S1 = new List<string>() { "Lorena Currie", "Jaeden Curtis", "Kloe Gallegos", "Amiee Ayers", "Aalia Kane", "Riley-James Terry", "Soren Luna", "Charleigh Meyers", "Tia Dejesus", "Vikram Aguilar" };
        public List<string> bsa2S1 = new List<string>() { "Aliyah Nash", "Jazmine Hodge", "Gabriel Benson", "Che Neal", "Sian Malone", "Grayson Mayer", "Donald O'Ryan", "Mert Chaney", "Esmay Norton", "Kimora Dickson", };
        public List<string> bsa3S1 = new List<string>() { "Mila Stark", "Saxon Oakley", "Muneeb Crossley", "Tessa Mcfadden", "Katy Needham", "Kaylem Mcintyre", "Ayaan Manning", "Sahara Kirk", "Arman Odom", "Hilda Walmsley", };
        public List<string> bsa4S1 = new List<string>() { "Janelle Nichols", "Riaan Garza", "Bronte Welch", "Cyrus Preston", "Sabah Mayer", "Shana Mack", "Leia Jenkins", "Margie Kaiser", "Jesus Colley", "Arda Davenport", };

        //BSA Number of Violation
        public List<int> bsa1S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsa2S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsa3S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsa4S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        //BSA Violation

        public List<string> bsa1S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsa2S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsa3S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsa4S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };

        // BSSE
        public List<string> bsse1S1 = new List<string>() { "Raja Solomon", "Mercedes Beck", "Cain Cortez", "Annabelle Mathews", "Tyla Williams", "Lochlan Stewart", "Karter Sparks", "Emilie Sheehan", "Callen Nolan", "Sanjeev Brook", };
        public List<string> bsse2S1 = new List<string>() { "Scarlett-Rose Terrell", "Lennon Romero", "Enrico English", "Simone Maddox", "Abdulrahman Greaves", "Misha Ramsey", "Marjorie Bowler", "Emeli Stout", "Carrie Drake", "Dillan Regan", };
        public List<string> bsse3S1 = new List<string>() { "Leo Castaneda", "Tilly-Mae Neal", "Alya Luna", "Darcy Curtis", "Kalem Ellison", "Rylan Larsen", "Ahsan Gutierrez", "Clark Andrew", "Raheel O'Gallagher", "Ottilie Davies", };
        public List<string> bsse4S1 = new List<string>() { "Emily Burris", "Manveer Hendricks", "Brandon Person", "Efa Hope", "Ayub Rivers", "Rebeca Enriquez", "Hughie Cherry", "Krishan Easton", "Sultan Edmonds", "Patrycja Fleming", };

        //BSSE Number of Violation

        public List<int> bsse1S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsse2S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsse3S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsse4S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        //BSSE Violation

        public List<string> bsse1S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsse2S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsse3S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsse4S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };

        // BSIE
        public List<string> bsie1S1 = new List<string>() { "Ignacy Salgado", "Alivia Banks", "Kacey Irwin", "Jorja Fenton", "Kloe Hutchings", "Dolores Appleton", "Alyssia Edwards", "Ava-May Rojas", "Asiya Noel", "Hebe Jordan", };
        public List<string> bsie2S1 = new List<string>() { "Kayne Marriott", "Arslan Sutton", "Kristofer Schroeder", "Haya Cummings", "Jaxson Whitley", "Kier Broadhurst", "Bernard Battle", "Poppie Colon", "Ameer Cohen", "Grant Ayers", };
        public List<string> bsie3S1 = new List<string>() { "Abdurahman Burgess", "Carlton Bradley", "Carlton Bradley", "Elaine Mccray", "Kaitlan Cain", "Reiss Stott", "Hisham Emery", "Tyriq Wainwright", "Cole Knapp", "Sidra Trujillo", };
        public List<string> bsie4S1 = new List<string>() { "Lloyd Sherman", "Joseph Ponce", "Sabrina Curry", "Wendy Adkins", "Franky Reynolds", "Evelyn Chavez", "Kaylem Mcintyre", "Isobella Norton", "Sahara Kirk", "Arman Odom", };

        //BSIE Number of Violation

        public List<int> bsie1S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsie2S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsie3S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsie4S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        //BSIE Violation

        public List<string> bsie1S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsie2S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsie3S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsie4S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };

        // BSCE
        public List<string> bsce1S1 = new List<string>() { "Harris Herrera", "Hilda Walmsley", "Janelle Nichols", "Riaan Garza", "Bronte Welch", "Cyrus Preston", "Sabah Mayer", "Leia Jenkins", "Margie Kaiser", "Jesus Colley", };
        public List<string> bsce2S1 = new List<string>() { "Arda Davenport", "Raja Solomon", "Mercedes Beck", "Cain Cortez", "Annika Whitworth", "Annabelle Mathews", "Tyla Williams", "Lochlan Stewart", "Karter Sparks", "Emilie Sheehan", };
        public List<string> bsce3S1 = new List<string>() { "Callen Nolan", "Sanjeev Brook", "Scarlett-Rose Terrell", "Neil O'Sullivan", "Lennon Romero", "Enrico English", "Simone Maddox", "Abdulrahman Greaves", "Misha Ramsey", "Marjorie Bowler", };
        public List<string> bsce4S1 = new List<string>() { "Emeli Stout", "Carrie Drake", "Dillan Regan", "Leo Castaneda", "Tilly-Mae Neal", "Alya Luna", "Alya Luna", "Darcy Curtis", "Kalem Ellison", "Rylan Larsen", };

        //BSCE Number of Violation

        public List<int> bsce1S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsce2S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsce3S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsce4S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        //BSCE Violation

        public List<string> bsce1S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsce2S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsce3S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsce4S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };

        // BSIT
        public List<string> bsit1S1 = new List<string>() { "Ahsan Gutierrez", "Taliah Heath", "Clark Andrew", "Raheel O'Gallagher", "Ottilie Davies", "Emily Burris", "Manveer Hendricks", "Brandon Person", "Ayub Rivers", "Rebeca Enriquez", };
        public List<string> bsit2S1 = new List<string>() { "Hughie Cherry", "Krishan Easton", "Sultan Edmonds", "Patrycja Fleming", "Ignacy Salgado", "Alivia Banks", "Kacey Irwin", "Jorja Fenton", "Kloe Hutchings", "Dolores Appleton", };
        public List<string> bsit3S1 = new List<string>() { "Yaqub Nicholls", "Ho Hudson", "Alyssia Edwards", "Ava-May Rojas", "Asiya Noel", "Hebe Jordan", "Kayne Marriott", "Arslan Sutton", "Jaxson Whitley", "Bernard Battle", };
        public List<string> bsit4S1 = new List<string>() { "Poppie Colon", "Ameer Cohen", "Grant Ayers", "Carlton Bradley", "Elaine Mccray", "Kaitlan Cain", "Reiss Stott", "Hisham Emery", "Tyriq Wainwright", "Sidra Trujillo", };

        //BSIT Number of Violation

        public List<int> bsit1S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsit2S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsit3S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public List<int> bsit4S1N = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        //BSIT Violation

        public List<string> bsit1S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsit2S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsit3S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
        public List<string> bsit4S1V = new List<string>() { "", "", "", "", "", "", "", "", "", "", };
    }
}
