using System;

namespace Lab7
{
    class MyString
    {
        private String str;
        public MyString()
        {
            str = null;
        }
        public MyString(String s)
        {
            str = s;
        }
        public static MyString operator +(MyString str1,MyString str2)
        {
            MyString newString = new MyString();
            newString.str = str1.str + str2.str;
            return newString;
        }
         public static bool operator <=(MyString str1, MyString str2)
         {
             if (str1.str.Length<=str2.str.Length)
             {
                return true;
             }
             return false;
         }
         public static bool operator >=(MyString str1, MyString str2)
         {
             if (str1.str.Length >= str2.str.Length)
             {
                 return true;
             }
            return false ;
         }
        //The Class Contains Defintions of Both Comparison(s) Means Comparing The String in terms 
        //of Length And Also The Comparing in terms of First letter of Two Strings
       /*  public static bool operator <=(MyString str1, MyString str2)
         {

       if(str1.str[0] <= str2.str[0]){
        return true;
         }
        return false;
         }
         public static bool operator >=(MyString str1, MyString str2)
         {
              if(str1.str[0] >= str2.str[0]){
        return true;
         }
        return false;

         }*/
        public String getString()
        {
            return str;
        }
        public void Test()
        {
            MyString str1 = new MyString("Michael ");
            MyString str2 = new MyString("Corleone");
            Console.WriteLine($"The First String is :{str1.getString()}");
            Console.WriteLine($"The Second String is :{str2.getString()}");
            MyString finalString = str1 + str2;
            Console.WriteLine("After Adding Them :"+finalString.getString());
            if (str1<=str2)
            {
                //The Condion is checked whether str1 is less than str2 
                //Since it is true the Statement is printed
                Console.WriteLine($"{str2.getString()} is Greater Than {str1.getString()} In Terms of Length !");
            }
            else
            {
                Console.WriteLine($"{str1.getString()} is Greater Than {str2.getString()} In Terms of Length !");
            }
        }
    }
}
