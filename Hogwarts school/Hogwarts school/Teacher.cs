using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_school
{
    class Teacher : Allowed_People
    {
        public bool Same_Time { get; set; }
        //-------------------------------- Home Work ---------------------------
        public void HomeWork()
        {
            string Homework = Console.ReadLine();
            Console.WriteLine($"Exercise :\n{Homework}\n Good job!");
        }
        //-------------------------------------- Teacher menu ------------------------------------
        public void T_menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" 1.Add Exercise \n 2. \n 3. ");
            Console.ResetColor();
            int Tchr_Ch = Console.Read();

            if (Tchr_Ch == 1)
                HomeWork();



        }
        //--------------------------------- Enter ------------------------------
        public void TEnter()
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
                    Console.WriteLine($"Welcome Mr./Mrs.:{ GlobalVariables.allowed_people[i].LastName}");
                    Console.ResetColor();

                    T_menu();

                }
            }

            for (int i = 0; i < 300; i++)
            {
                if (GlobalVariables.allowed_people[i].Username != S_Use || GlobalVariables.allowed_people[i].Password != S_Pass)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong username or password!\n");
                    Console.ResetColor();
                    TEnter();
                }

            }

        }

    }
}
