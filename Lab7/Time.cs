using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Time
    {
        /*Using the 24 hour Format !*/
        private int seconds, minutes, hours;
        public Time()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public Time(int h,int m,int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public static Time operator ++(Time time)
        {
            if (time.seconds >= 59)
            {
                if (time.minutes >= 59)
                {
                    if (time.hours>=23)
                    {
                        time.hours=0;
                        time.minutes = 0;
                        time.seconds = 0;
                    }
                    else
                    {
                        time.hours++;
                        time.minutes = 0;
                        time.seconds = 0;
                    }
                   
                }
                else
                {
                    time.minutes++;
                    time.seconds = 0;
                }
            }
            else {
                time.seconds++;
            }
            return time;
        }
        public static Time operator +(Time time1 ,Time time2)
        {
            
            Time newTime = new Time();
            newTime.hours = time1.hours+time2.hours;
            newTime.minutes = time1.minutes + time2.minutes;
            newTime.seconds= time1.seconds+time2.seconds;
            if (newTime.seconds>=59)
            {
                newTime.minutes++;
                newTime.seconds =newTime.seconds%60;
                if (newTime.minutes>=59)
                {
                    newTime.hours++;
                    newTime.minutes = newTime.minutes % 60;
                    if (newTime.hours>=23)
                    {
                        newTime.hours = 0;
                    }
                }
            }

            return newTime;
        }
        public String showTime()
        {
            return $"The Time is {hours}:{minutes}:{seconds} HRS";
        }
        public void Test()
        {
            Console.WriteLine("1)Increment Time \n2)Add Two Times\n3)Exit !");
            int choice = int.Parse(Console.ReadLine());
            Time time = new Time(1,59,59);
            Time time1 = new Time(1,1,1);
            Time time3 = time1 + time;
            switch (choice)
            {
                case 1:
                    time++;
                    Console.WriteLine(time.showTime());
                    break;
                case 2:
                    Console.WriteLine(time3.showTime());
                    break;
                default:
                    break;
               
            }
        }
    }
}
