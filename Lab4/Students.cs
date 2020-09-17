using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Students
    {
        private String full_name, course, subject, university, email;
        private long ? phone=null;
        public Students()
        {
            full_name = null;
            course = null;
            subject = null;
            university= null;
            email = null;
            phone = null;
        }
        public Students(String f_name,String course_con,String subject_con,String uni,String em,long phone_num)
        {
            full_name = f_name;
            course = course_con;
            subject = subject_con;
            university = uni;
            email = em;
            phone = phone_num;
        }
        public Students(String f_name, String uni, String em, long phone_num)
        {
            full_name = f_name;
            university = uni;
            email = em;
            phone = phone_num;
        }
        public Students(String f_name, String uni, String em)
        {
            full_name = f_name;
            university = uni;
            email = em;
            
        }
        public Students(String f_name, String uni, String university_con, String em, long phone_number)
        {
            full_name = f_name;
            university = university_con;
            email = em;
            phone = phone_number;
        }
        public String return_info()
        {
            return full_name+"\n"+course+"\n" + subject+ "\n" + university + "\n" + email + "\n" + phone+"\n" ;
        }
    }
}
