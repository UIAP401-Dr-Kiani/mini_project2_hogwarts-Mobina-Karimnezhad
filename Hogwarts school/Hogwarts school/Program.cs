using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_school
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------- reading file -----------------------------
            using (StreamReader file = new StreamReader("TXT_DATA.tsv"))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    string[] human = ln.Split('\t').ToArray<string>();
                    /*
                    human[0] = name
                    human[1] = family
                    human[2] = dataOfBirth
                    human[3] = gender
                    human[4] = father
                    human[5] = username
                    human[6] = password
                    human[7] = race type
                    human[8] = role
                    */
                    Console.Write(human[0][0]);
                }


                file.Close();
               
            }
            //Console.Write(hu)

            Allowed_People[] allowed_people = new Allowed_People[300];
            for (int i = 0; i < 300; i++)
            {
                Allowed_People A = new Allowed_People();
            }
            
            //------------------------------------- menu --------------------------------------
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~. Welcom to Hogwarts .~.~.~.~.~.~.~.~.~.~.~.~");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" 1.Admin \n 2.Teacher \n 3.Student ");
            Console.ResetColor();

            int menu_Ch = Convert.ToInt32(Console.ReadLine());

        }
    }
}
