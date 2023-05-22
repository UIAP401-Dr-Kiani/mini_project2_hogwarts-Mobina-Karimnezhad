using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_school
{
    class Groups
    {
        public string Type { get; set; }

        //--------------------------------------
        public int Score { get; set; }

        //--------------------------------------
        public List<string> Hufflepuff_Members = new List<string>();
        public List<string> Gryffindor_Members = new List<string>();
        public List<string> Ravenclaw_Members = new List<string>();
        public List<string> Slytherin_Members = new List<string>();

        //--------------------------------------
        List<string> Queeditch = new List<string>();

        //--------------------------------------

    }
}
