using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Student
    {
        private int code;
        private String name;
        private int age;
        public int Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int  Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
