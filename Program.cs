using extension.models;
using System;

namespace extension
{
    class Program
    {
        static void Main(string[] args)
        {

            user stu1 = new user("muradama@code.edu.az");
            stu1.Fullname = "Murad Abdullayev";
            Console.WriteLine(stu1.Passwordchecker("Murad2000"));
            stu1.Getinfo();
            
        }
    }
}
