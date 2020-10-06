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
            //Creating a New Time Object to store the added time 
            Time newTime = new Time();
            //Adding the corresponding Hour, seconds,minutes 
            newTime.hours = time1.hours+time2.hours;
            newTime.minutes = time1.minutes + time2.minutes;
            newTime.seconds= time1.seconds+time2.seconds;
            if (newTime.seconds>=59)
            {
                //If Seconds is greater than 59 then minutes is incremented 
                //And the New seconds is remainder of seconds after division by 60
                newTime.minutes++;
                newTime.seconds =newTime.seconds%60;
                if (newTime.minutes>=59)
                {
                    //If Minutes is greater than 60 then hour is increamented and new Minutes is remainder of minutes after divison by 60
                    newTime.hours++;
                    newTime.minutes = newTime.minutes % 60;
                    if (newTime.hours>=23)
                    {
                        //If Hour is greater than 23 then is converted to 0 as per 24 hrs standards
                        newTime.hours = 0;
                    }
                }
            }

            return newTime;
        }
        public String showTime()
        {
            //String methods to show Time !
            return $"The Time is {hours}:{minutes}:{seconds} HRS";
        }
        public void Test()
        {
            Console.WriteLine("1)Increment Time \n2)Add Two Times\n3)Exit !");
            //Choice whether the time is to be incremented or Added
            int choice = int.Parse(Console.ReadLine());
            Time time = new Time(1,59,0);
            Time time1 = new Time(1,0,1);
            Time time3 = time1 + time;
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Before Incrementing {time.showTime()}");
                    time++;
                    Console.WriteLine($"After Incrementing {time.showTime()}");
                    break;
                case 2:
                    Console.WriteLine($"Time Object One :{time.showTime()}");
                    Console.WriteLine($"Time Object Two :{time1.showTime()}");
                    Console.WriteLine($"After Adding Them :{time3.showTime()} ");
                    break;
                default:
                    Console.WriteLine("Invlaid !!!");
                    break;
               
            }
        }
    }
}
