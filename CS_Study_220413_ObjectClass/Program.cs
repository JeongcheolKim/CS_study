using System;

//Object Class -> 4 methods
//ToString, GetType, Equals, GetHashCode

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.ToString());  // App1.Program


            int n = 500;
            double d = 3.14159265358;

            string txt = "Start : ";

            Console.WriteLine(txt + n.ToString());  // Start : 500
            Console.WriteLine(txt + d.ToString());  // Start : 3.14159265358

            txt = d.ToString();
            Console.WriteLine(txt); // 3.15159265358

        }


    }
}