using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Hogwarts_school
{
    public class Teacher : Allowed_People
    {
        public bool Same_Time { get; set; }
        public List<string> Homework_lst = new List<string>();
        //-------------------------------- Home Work ---------------------------
        public void HomeWork()
        {
            Console.WriteLine("Exercise:");
            string Homework = Console.ReadLine();
            Homework_lst.Add(Homework);
        }
        //-------------------------------------- Teacher menu ------------------------------------
        public void T_menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" 1.Add Exercise \n 2.Schedule \n 3.Exit ");
            Console.ResetColor();
            int Tchr_Ch = Convert.ToInt32(Console.ReadLine());

            if (Tchr_Ch == 1)
                HomeWork();
            if (Tchr_Ch == 2)
                TSchedule();
            if (Tchr_Ch == 3)
            {
                Program p = new Program();
                Program.main_menu();
            }
                



        }
        //--------------------------------- Enter ------------------------------
        public void TEnter()
        {
            Console.Write("Username:");
            string T_Use = Console.ReadLine();
            Console.Write("Password:");
            string T_Pass = Console.ReadLine();

            for (int i = 0; i < 300; i++)
            {

                if (GlobalVariables.allowed_people[i].Username == T_Use && GlobalVariables.allowed_people[i].Password == T_Pass)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Welcome Mr/Mrs { GlobalVariables.allowed_people[i].LastName}");
                    Console.ResetColor();

                    T_menu();
                    break;

                }
                else
                {
                    if (i == 299)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong username or password!\n");
                        Console.ResetColor();
                        TEnter();
                    }
                    else
                        continue;

                }
            }

            

        }
        //-------------------------------------------- Schedule ----------------------------
        public void TSchedule()
        {
            string[,] TSchedule = new string[6,5];
            
            TSchedule[0,0] = "    ";
            TSchedule[0,1] = "8-10";
            TSchedule[0,2] = "10-12";
            TSchedule[0,3] = "14-16";
            TSchedule[0,4] = "16-18";
            TSchedule[1,0] = "Mon";
            TSchedule[2,0] = "Tue";
            TSchedule[3,0] = "Wed";
            TSchedule[4,0] = "Thu";
            TSchedule[5,0] = "Fri";
            for(int i = 1; i < 6; i++)
                for(int j = 1; j < 5; j++)
                {
                    TSchedule[i,j] = null;
                }

            Console.WriteLine("Teaching at same tiem ? (true / false)");
            Same_Time = Convert.ToBoolean(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (TSchedule[i, j] == null)
                        Console.Write("      ");
                    else
                        Console.Write($"{TSchedule[i, j]}\t");
                }
                Console.Write("\n\n\n");
            }
            //============================================== false
            if(Same_Time == false)
            {
                while (true)
                {
                    Console.Write("Lesson( Botany / Chemistry / Magics / PE ) : ");
                    string lesson = Console.ReadLine();
                    Console.Write("row num :");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("column num :");
                    int column = Convert.ToInt32(Console.ReadLine());

                    if (TSchedule[row, column] == null)
                        TSchedule[row, column] = lesson;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Overlap!");
                        Console.ResetColor();
                    }

                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (TSchedule[i, j] == null)
                                Console.Write("                       ");
                            else
                                Console.Write($"{TSchedule[i, j]}\t\t\t");
                        }
                        Console.Write("\n\n\n");
                    }

                    Console.Write("Continue ?(Y/N)");
                    string answer = Console.ReadLine();
                    if (answer == "Y" || answer == "y")
                        continue;
                    else
                    {
                        GlobalVariables.Schedules.Add(TSchedule);
                        T_menu();
                    }
                        

                }
            }
            //========================================== true
            if(Same_Time == true)
            {
                while (true)
                {
                    Console.Write("Lesson( Botany / Chemistry / Magics / PE ) : ");
                    string lesson = Console.ReadLine();
                    Console.Write("row num :");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("column num :");
                    int column = Convert.ToInt32(Console.ReadLine());

                    if (TSchedule[row, column] == null)
                        TSchedule[row, column] = lesson;
                    else
                    {
                        TSchedule[row, column] = TSchedule[row, column] + "/" + lesson;
                    }

                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (TSchedule[i, j] == null)
                                Console.Write("                       ");
                            else
                                Console.Write($"{TSchedule[i, j]}\t\t\t");
                        }
                        Console.Write("\n\n\n");
                    }

                    Console.Write("Continue ?(Y/N)");
                    string answer = Console.ReadLine();
                    if (answer == "Y" || answer == "y")
                        continue;
                    else
                    {
                        GlobalVariables.Schedules.Add(TSchedule);
                        T_menu();
                    }
                        

                }
            }
            //string[,] B = (string[,])GlobalVariables.Schedules[0];
            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (TSchedule[i, j] == null)
            //            Console.Write("         ");
            //        else
            //            Console.Write($"{TSchedule[i, j]}\t\t");
            //    }
            //    Console.Write("\n\n\n");
            //}




        }
        //----------------------------------------------------------------------------------------


    }
}
