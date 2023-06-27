using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_school
{
    public class Allowed_People : Human
    {
        public int RoomNumber { get; set; }

        //--------------------------------------
        public string Schedule { get; set; }

        //--------------------------------------
        public string pet { get; set; }

        //--------------------------------------
        public string Group { get; set; }

        //--------------------------------------
        public bool Suitcase { get; set; }

        //--------------------------------------
        public string Role { get; set; }

        //--------------------------------------
        public string[] Letter { get; set; }

        //--------------------------------------- Letters Arrays ------------------------------
        //public void Letter_Arrays()
        //{
        //    for (int i = 0; i < 300; i++)
        //    {
        //        string[] LA = new string[200];
        //    }
        //}
    }
}
