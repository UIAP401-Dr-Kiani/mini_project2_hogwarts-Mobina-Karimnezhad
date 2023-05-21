using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hogwarts_school
{
    class Student : Allowed_People
    {
        public int Passed { get; set; }

        //--------------------------------------
        public int Term { get; set; }

        //--------------------------------------
        public int Dormitory_Num { get; set; }
        //--------------------------------------
        Program p = new Program();
        //--------------------------------------
        List<string> All_Lessons = new List<string>()
        {
            "PE",
            "Magics",
            "Botany1",
            "Botany2",
            "Botany3",
            "Botany4",
            "Chemistry"
        };

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
                    break;

                }
                else
                {
                    if (i == 299)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong username or password!\n");
                        Console.ResetColor();
                        SEnter();
                    }
                    else
                        continue;

                }
            }



        }
        
        //--------------------------------------- Student menu ---------------------------------
        public void S_menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" 1.Dining Room \n 2.Letters \n 3.Homeworks \n 4.Exit");
            Console.ResetColor();
            int Std_Ch = Convert.ToInt32(Console.ReadLine());
            //------------------------------------Dining room----------------------------------
            if (Std_Ch == 1)
            {
                Console.WriteLine("Enter your term :");
                Term = Convert.ToInt32(Console.ReadLine());


                if (Term == 1)
                {
                    string[,] S1Schedule = new string[6, 5];

                    S1Schedule[0,0] = "    ";
                    S1Schedule[0,1] = "8-10";
                    S1Schedule[0,2] = "10-12";
                    S1Schedule[0,3] = "14-16";
                    S1Schedule[0,4] = "16-18";
                    S1Schedule[1,0] = "Mon";
                    S1Schedule[2,0] = "Tue";
                    S1Schedule[3,0] = "Wed";
                    S1Schedule[4,0] = "Thu";
                    S1Schedule[5,0] = "Fri";
                    S1Schedule[2,3] = "PE";
                    S1Schedule[2,2] = "Magics";
                    S1Schedule[3,3] = "Botany1";
                    S1Schedule[1,3] = "Chemistry";

                    for (int j = 0; j < 6; j++)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            if (S1Schedule[j, k] == null)
                                Console.Write("                       ");
                            else
                                Console.Write($"{S1Schedule[j, k]}\t\t\t");
                        }
                        Console.Write("\n\n\n");
                    }



                }
                else
                {
                    Take_Lesson();
                }
            }
            if (Std_Ch == 4)
                p.main_menu();

        }
        //-------------------------------------- Take lessons ------------------------------------
        public void Take_Lesson()
        {
            for(int i = 0; i < GlobalVariables.Schedules.Count; i++)
            {
                string[,] B = (string[,])GlobalVariables.Schedules[i];
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (B[j, k] == null)
                            Console.Write("                       ");
                        else
                            Console.Write($"{B[j, k]}\t\t\t");
                    }
                    Console.Write("\n\n\n");
                }
                Console.WriteLine("======================================================");

            }
            //========================================== not first term ===========================================
            string[,] SSchedule = new string[6, 5];

            SSchedule[0, 0] = "    ";
            SSchedule[0, 1] = "8-10";
            SSchedule[0, 2] = "10-12";
            SSchedule[0, 3] = "14-16";
            SSchedule[0, 4] = "16-18";
            SSchedule[1, 0] = "Mon";
            SSchedule[2, 0] = "Tue";
            SSchedule[3, 0] = "Wed";
            SSchedule[4, 0] = "Thu";
            SSchedule[5, 0] = "Fri";
            for (int i = 1; i < 6; i++)
                for (int j = 1; j < 5; j++)
                {
                    SSchedule[i, j] = null;
                }

            
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (SSchedule[i, j] == null)
                        Console.Write("      ");
                    else
                        Console.Write($"{SSchedule[i, j]}\t");
                }
                Console.Write("\n\n\n");
            }

            for (int k = 0; k < 5; k++)
            {
                Console.Write("Lesson( Botany1 / Botany2 / Botany3 / Botany4 / Chemistry / Magics / PE ) : ");
                string lesson = Console.ReadLine();
                Console.Write("row num :");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("column num :");
                int column = Convert.ToInt32(Console.ReadLine());
                //===============================================

                for(int i = 0 ; i < All_Lessons.Count ; i++)
                {
                    if (lesson == All_Lessons[i])
                        All_Lessons.Remove(lesson);
                }

                for (int i = 0; i < All_Lessons.Count; i++)
                {
                    if (lesson != All_Lessons[i])
                    {
                        if (i == All_Lessons.Count - 1)
                        {
                            Console.WriteLine("Not found!");
                            break;
                        }
                        else
                            continue;
                    }

                        
                }
                //===============================================

                if (SSchedule[row, column] == null)
                    SSchedule[row, column] = lesson;
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
                        if (SSchedule[i, j] == null)
                            Console.Write("                       ");
                        else
                            Console.Write($"{SSchedule[i, j]}\t\t\t");
                    }
                    Console.Write("\n\n\n");
                }
                if (k < 3)
                    continue;
                Console.Write("Continue ?(Y/N)");
                string answer = Console.ReadLine();
                if (answer == "Y" || answer == "y")
                    continue;
                else
                {
                    GlobalVariables.Schedules.Add(SSchedule);
                    S_menu();
                    
                }

            

                }
            }
        //-----------------------------------------------------------------------------------------------
        
        

        }
    }


