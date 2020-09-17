using System;

namespace Question8
{
    class ClassTime
    {
        private int date, month, year, hour, seconds, minutes;
        public ClassTime()
        {
            date = DateTime.Now.Day;
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            hour = DateTime.Now.Hour;
            seconds = DateTime.Now.Second;
           minutes=DateTime.Now.Minute;
        }
        public String Display()
        {
            return "Curent Date: " + date + "/" + month + "/" + year + "\nCurrent Time:" + hour + ":" +minutes+":"+seconds;
        }
        static void Main(string[] args)
        {
            ClassTime time = new ClassTime();
            Console.WriteLine(time.Display());
        }
    }
}
