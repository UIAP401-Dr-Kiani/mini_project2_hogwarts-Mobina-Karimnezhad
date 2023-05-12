using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_school
{
    class Student : Allowed_People
    {
        public int Passed { get; set; }

        //--------------------------------------
        public int Term { get; set; }

        //--------------------------------------
        public int Dormitory_Num { get; set; }

        //-------------------------------------- Enter ------------------------------------
        public void SEnter()
        {
            Console.Write("Username:");
            string S_Use = Console.ReadLine();
            Console.Write("Password:");
            string S_Pass = Console.ReadLine();
            
            for (int i = 0; i < 300; i++)
            {

                if (GlobalVariables.allowed_people[i].Username == S_Use && GlobalVariables.allowed_people[i].Password == S_Pass)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Welcome :{GlobalVariables.allowed_people[i].Name + " " + GlobalVariables.allowed_people[i].LastName}");
                    Console.ResetColor();

                    S_menu();

                }
            }

            for ( int i =0; i<300; i++)
            {
                if (GlobalVariables.allowed_people[i].Username != S_Use || GlobalVariables.allowed_people[i].Password != S_Pass)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong username or password!\n");
                    Console.ResetColor();
                    SEnter();
                }

            }
            
        }
        //--------------------------------------- Student menu ---------------------------------
        public void S_menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" 1.Dining Room \n 2.Letters \n 3. ");
            Console.ResetColor();
            int Std_Ch = Console.Read();
            if (Std_Ch == 2)
            {

            }
        }
        //-----
    }
}
