using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_school
{
    public class Dormitory
    {
        public string Group { get; set; }

        //--------------------------------------
        public int Floors { get; set; }

        //--------------------------------------
        public int Rooms { get; set; }

        //--------------------------------------
        public int Beds { get; set; }

        //--------------------------------------
        public string Sexuality { get; set; }
        //--------------------------------------
        public static List<string> Codes = new List<string>();

        //-------------------------------------- static code ---------------------------------------
        static int i = 0;
        public static void code()
        {
            for(int i = 1; i < 5; i++)
                for(int j = 1; j < 6; j++)
                    for(int k = 1; k < 3; k++)
                    {
                        string code = $"Your code is : {i}{j}{k}";
                        Codes.Add(code); 
                    }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Codes[i]);
            Console.ResetColor();
            i++;

        }
        //-------------------------------------------------------------------------------------------


    }
}
