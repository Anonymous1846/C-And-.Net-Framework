using System;

namespace Question6
{
    class Person
    {
        int age;
        String firstName, lastName;
        public Person()
        {
            firstName = null;
            lastName = null;
            age = 0;
        }
        public void getInfo(String fn,String ln,int a)
        {
            firstName = fn;
            lastName = ln;
            age = a;
        }
        public  String put_info()
        {
            return firstName+ " " + lastName;
        }
        public  int put_age()
        {
            return age;
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.getInfo("Leo","DiCaprio",45);
            Console.WriteLine("Hello,"+person.put_info()+", You Must Be "+person.put_age()+" years old !");
        }
    }
}
