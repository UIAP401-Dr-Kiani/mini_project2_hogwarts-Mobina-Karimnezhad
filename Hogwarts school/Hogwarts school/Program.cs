﻿using System;
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
            Allowed_People A = new Allowed_People();
            Allowed_People[] allowed_people = new Allowed_People[300];

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
                    allowed_people[j] = new Allowed_People();
                    allowed_people[j].Name = human[0];
                    allowed_people[j].LastName = human[1];
                    allowed_people[j].BirthYear = human[2];
                    allowed_people[j].Sexuality = human[3];
                    allowed_people[j].Father = human[4];
                    allowed_people[j].Username = human[5];
                    allowed_people[j].Password = human[6];
                    allowed_people[j].Origin = human[7];
                    allowed_people[j].Role = human[8];
                    j++;
                }


                file.Close();
                Console.WriteLine(allowed_people[0].Name);
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
