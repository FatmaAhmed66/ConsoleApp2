using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ////Write a program that allows the user to enter a number then print it
            ///

            Console.Write("Enter a number ");


            string input = Console.ReadLine();

            Console.Write("your number is " + input);



            #endregion



            #region Q2
            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen



            int x = 10;
            int y = x;

            Console.WriteLine("BEFORE MODIFICATION ");
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("AFTER MODIFICATION ");
            x--;
            Console.WriteLine(x);
            Console.WriteLine(y);

            ///the x only changed and y remains the same x=9 y=10

            #endregion




            #region Q3





            Number n1 = new Number();
            Number n2 = new Number();

            n2 = n1;
            Console.WriteLine("BEFORE MODIFICATION ");

            Console.WriteLine(n1.x);
            Console.WriteLine(n1.y);
            Console.WriteLine(n2.x);
            Console.WriteLine(n2.y);


             n1.x = 15;
             n1.y = 20;

            Console.WriteLine("AFTER MODIFICATION ");
            Console.WriteLine(n1.x);
            Console.WriteLine(n1.y);
            Console.WriteLine(n2.x);
            Console.WriteLine(n2.y);

            //both variables refer to the same object in memory  so the change is reflected in both variables
            #endregion
        }









    }
}
