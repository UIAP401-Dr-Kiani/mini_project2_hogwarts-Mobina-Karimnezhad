using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_school
{
    public class Program
    {
        Dumbeldore d = new Dumbeldore();

        public void AEnter()
        {
            Console.Write("Username:");
            string Ausername = Console.ReadLine();
            Console.Write("Password:");
            string Apassword = Console.ReadLine();

            if (Ausername == "Admin" && Apassword == "Admin")
            {
                Console.WriteLine("Correct!");
                d.D_menu();
            }
               

            else
                AEnter();
        }
        public void main_menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" 1.Admin \n 2.Teacher \n 3.Student ");
            Console.ResetColor();

            int menu_Ch = Convert.ToInt32(Console.ReadLine());
            //---------------------------------- Admin --------------------------
            if (menu_Ch == 1)
            {
                AEnter();

            }
            //--------------------------------- Teacher -------------------------
            Teacher Tchr = new Teacher();
            if (menu_Ch == 2)
            {
                Tchr.TEnter();

            }
            //--------------------------------- Stuent --------------------------
            Student Std = new Student();

            if (menu_Ch == 3)
                Std.SEnter();

            Console.ReadKey();


        }
        static void Main(string[] args)
        {
            //---------------------------------- reading file -----------------------------
            //Allowed_People A = new Allowed_People();
            //Allowed_People[] allowed_people = new Allowed_People[300];

            using (StreamReader file = new StreamReader("TXT_DATA.tsv"))
            {
                string ln;
                int j = 0;
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
                    GlobalVariables.allowed_people[j] = new Allowed_People();
                    GlobalVariables.allowed_people[j].Name = human[0];
                    GlobalVariables.allowed_people[j].LastName = human[1];
                    GlobalVariables.allowed_people[j].BirthYear = human[2];
                    GlobalVariables.allowed_people[j].Sexuality = human[3];
                    GlobalVariables.allowed_people[j].Father = human[4];
                    GlobalVariables.allowed_people[j].Username = human[5];
                    GlobalVariables.allowed_people[j].Password = human[6];
                    GlobalVariables.allowed_people[j].Origin = human[7];
                    GlobalVariables.allowed_people[j].Role = human[8];
                    GlobalVariables.allowed_people[j].Letter = null;
                    j++;
                    
                }


                file.Close();
                
            }


            //------------------------------------- menu --------------------------------------
            Dumbeldore D = new Dumbeldore();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~. Welcom to Hogwarts .~.~.~.~.~.~.~.~.~.~.~.~");
            Console.ResetColor();
            Program p = new Program();           
            p.main_menu();
            
        
            


    }
    }
}
