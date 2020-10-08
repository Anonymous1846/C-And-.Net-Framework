using System;


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
            int hr, sc, min;
            //Creating a New Time Object to store the added time 
            Time newTime = new Time();
            //Adding the corresponding Hour, seconds,minutes 
            hr = time1.hours+time2.hours;
            min = time1.minutes + time2.minutes;
            sc= time1.seconds+time2.seconds;  
            if (sc>60)
            {
                //If Seconds is greater than 59 then minutes is incremented 
                //And the New seconds is remainder of seconds after division by 60
                min++;
                sc = sc % 60;
                if (min>60)
                {
                    //If Minutes is greater than 60 then hour is increamented and new Minutes is remainder of minutes after divison by 60
                    hr++;
                    min = min % 60;
                    if (hr >24)
                    {
                        //If Hour is greater than 23 then is converted to remainder of 24 as per 24 hrs standards
                        hr = hr % 24;
                    }
                }
            }
            newTime.hours = hr;
            newTime.minutes = min;
            newTime.seconds = sc;
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
            Time time = new Time(10,59,59);
            Time time1 = new Time(10,1,2);
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
                    Console.WriteLine("Invalid !!!");
                    break;
               
            }
        }
    }
}
