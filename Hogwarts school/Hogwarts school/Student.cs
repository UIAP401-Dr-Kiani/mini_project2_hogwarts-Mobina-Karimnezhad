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
        public void Enter()
        {
            Console.Write("Username:");
            string S_Use = Console.ReadLine();
            Console.Write("Password:");
            string S_Pass = Console.ReadLine();
            //???????????????????????????????????????????????

        }
        //--------------------------------------- Student menu ---------------------------------
        public void S_menu()
        {
           // Console.WriteLine(" 1.Dining Room \n 2.")
        }
    }
}
