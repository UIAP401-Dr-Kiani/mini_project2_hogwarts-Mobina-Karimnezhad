using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_school
{
    public class Dumbeldore : Allowed_People
    {
        //------------------------------------- Send Letter ----------------------------------
        public void Send_Ltr1() //It's for sending students the invitation. 
        {
            //for (int j = 0; j < 300; j++)
            //{
            //    int std_num = 0;
            //    if (GlobalVariables.allowed_people[j].Role == "student")
            //        std_num++;
            //}
            ////for (int j = 0; j < ) 
            //for( int i = 0; i <300; i++)
            //{
            //    if( GlobalVariables.allowed_people[i].Role == "student")
            //    {


            //    }
            //}
            for (int i = 0; i < 300; i++)
            {
                if (GlobalVariables.allowed_people[i].Role == "student")
                {
                    Allowed_People A = new Allowed_People();
                    for (int j = 0; j < 100; j++)
                    {
                        A.Letter[j] = "Hi";
                    }
                }

            }
        }
    }
}
