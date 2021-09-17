using System;
using System.Linq;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chapter One
            //#5
            Console.WriteLine("Brandon Gunthner\n");

            //#12
            //The .NET Framework is a software platform developed by Microsoft that acts as a virtual machine which handles the compilation and execution of 
            //programs across multiple hardware platforms and OS's simplifying the execution and porting of code. C# is one of several programming languages
            //built off of the .NET Framework. It utilizes the libraries, runtime environment, and structure of the .NET Framework to provide a convenient and
            //powerful medium for developers to create progams.

            //Chapter Two
            //#8
            string s1 = "Hello";
            string s2 = "World";
            object obj = String.Concat(s1, " ", s2);
            string final = obj.ToString();

            Console.WriteLine(final + "\n");

            //#12
            string First_Name = "Bob";
            string Last_Name = "Ross";
            byte Age = 79;
            bool Is_Manager = true;
            uint Employee_ID = 27569690;

            //Chapter Four
            //#6
            int int1, int2;
            bool run = true;
            int[] intarray = new int[2];
            while (run == true)
            {
                Console.WriteLine("Enter the first whole number");
                string str1 = Console.ReadLine();
                bool parseSuccess = Int32.TryParse(str1, out int1);
                if (parseSuccess == true)
                {
                    intarray[0] = int1;
                    run = false;
                }
                else
                {
                    Console.WriteLine("Invalid Number!");
                }
            }
            run = true;
            while (run == true)
            {
                Console.WriteLine("Enter the second whole number");
                string str2 = Console.ReadLine();
                bool parseSuccess = Int32.TryParse(str2, out int2);
                if (parseSuccess == true)
                {
                    intarray[1] = int2;
                    run = false;
                }
                else
                {
                    Console.WriteLine("Invalid Number!");
                }
            }
            Console.WriteLine("\n" + intarray.Max() + "\n");

            //#7
            int num, sum = 0, run_iter = 0;
            string in_str;
            bool SevenRun = true;
            while(run_iter < 5)
            {
                while (SevenRun == true)
                {
                    Console.WriteLine("Enter number " + (run_iter + 1));
                    in_str = Console.ReadLine();
                    bool parseSuccess = Int32.TryParse(in_str, out num);
                    if (parseSuccess == true)
                    {
                        sum += num;

                        SevenRun = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number!");
                    }
                }
                run_iter += 1;
                SevenRun = true;
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
