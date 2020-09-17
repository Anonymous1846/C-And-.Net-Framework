using System;

namespace Lab3
{
    class Time
    {
        int hour, min, sec;
        public String getTime()
        {

            return "The Time is :" + Convert.ToString(hour)+":"+Convert.ToString(min)+ ":"+Convert.ToString(sec);
        }
        public void SetTime(int hr, out int minutes, ref int second)
        {
            minutes = 0;
            min = minutes;
            hour = hr;
            sec = second;
            if (sec >= 60)
            {
                min = ++minutes;
                sec %= 60;
                if (min >= 60)
                {
                    hour = ++hr;
                    min %= 60;
                }

            }
        }
        public void SetTimeAgain(ref int hr, ref int minutes, ref int second)
        {
            min = minutes;
            hour = hr;
            sec = second;
            if (sec>=60)
            {
                min = ++minutes;
                sec %= 60;
                if (min >= 60)
                {
                    hour = ++hr;
                    min %= 60;
                }
                

            }
          
        }

        }
    }

