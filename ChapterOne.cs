using System;
namespace ChapterOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //#2
            // System.Console is the built in class meant for handing input/output to the console

            //#3
            // Console.WriteLine is the built in function of the System.Console class that prints output to the console and accepts format parameters alongside the string/variable/literal arguments to be printed

            //#4
            Console.WriteLine("There's a snake in my boot!");

            //#5
            Console.WriteLine("Brandon Gunthner");

            //#6
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            //#7
            double square = Math.Sqrt(12345);
            Console.WriteLine(square);

            //#8
            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            age += 10;
            Console.WriteLine(age);

            //#9
            // C# is a programing language where as the .NET framework is the framework from which the C# language was built
            
            //#10
            //Java, Javascript, C++/C#, Python, Ruby 
            //Java is built on the Java Runtime Environment as opposed to the Common Language Runtime that C# is built on, both are Object Oriented languages
            //Javascript differs from both C# and Java significantly, JS has loose variable typing and is an interpreted language as opposed to compiled
            //Python also differs heavily from C#, it is interpreted and has dynamically typed variables as well as significantly different syntax
            //Ruby is another dynamically typed language and is also Open Source allowing for community based development of the language
        }
    }
}
