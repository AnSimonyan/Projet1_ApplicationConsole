﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet1_ApplicationConsole.App;

namespace Projet1_ApplicationConsole.Data
{
    public class AppData
    {
        public List<Student> StudentsList { get; }

        public List<Course> CoursesList { get; }

        public AppData()
        {
            StudentsList = new List<Student>();
            CoursesList = new List<Course>();
        }
    }
}
