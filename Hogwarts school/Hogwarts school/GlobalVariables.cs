﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hogwarts_school
{
    public class GlobalVariables
    {
        public Allowed_People A = new Allowed_People();
        public static Allowed_People[] allowed_people = new Allowed_People[300];
        public Dumbeldore D = new Dumbeldore();

        public static ArrayList Schedules = new ArrayList();


    }
}
