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


    }
}
