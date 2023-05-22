using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_school
{
    public class Dumbeldore : Allowed_People
    {
        Program P = new Program();
        //------------------------------------- Dumbeldore Menu ------------------------------
        public void D_menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" 1.Send letter \n 4.Exit");
            Console.ResetColor();
            int Admin_Ch = Convert.ToInt32(Console.ReadLine());
            //================================= 1
            if (Admin_Ch == 1)
                Send_Ltr1();
            //================================= 2
            if (Admin_Ch == 2)
                P.main_menu();
                
        }
        //------------------------------------- Send Letter ----------------------------------
        public void Send_Ltr1() //It's for sending students the invitation. 
        {
       
            for (int i = 0; i < 300; i++)
            {
                if (GlobalVariables.allowed_people[i].Role == "student")
                {
                    Allowed_People A = new Allowed_People();
                    for (int j = 0; j < 100; j++)
                    {
                        A.Letter[j] = "Hello dear students\nWe are pleased to inform you that you have been accepted at Hogwarts school of witchcraft and wizardry.\nPlease find enclosed a list of all necessary books and equipment.\nHeadmaster: Albus Dumbeldore";
                    }
                }

            }
        }
    }
}
