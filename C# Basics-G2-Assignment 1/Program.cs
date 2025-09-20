using System;
using System.ComponentModel;
using System.Globalization;
using System.Net.Security;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Basics_G2_Assignment_1
{
    internal class Program
    {
        internal class S
        {
            public int x;
            public int y;
        };

        static void Main(string[] args)
        {

            #region Q1
            //Write a program that allows the user to enter a number then print it.


            //Console.Write("Enter your number : ");
            //int.TryParse(Console.ReadLine(),out int num);
            //Console.WriteLine(num);
            #endregion

            #region Q2
            /*Write C# program that converts a string to an integer,
            but the string contains non-numeric characters. And mention what will happen*/

            //string word = "Question";
            //int x = Convert.ToInt32(word);
            //Console.WriteLine(x);

            /* it will throw an exception that string in not correct format because it can not
             convert characters to integer here (Runtime Error)*/

            #endregion

            #region Q3
            /*Write C# program that Perform a simple arithmetic operation with floating-point numbers 
              And mention what will happen*/

            //float x = 0.2f + 0.5f;
            //Console.WriteLine(x);

            /* it will print the value 0.7 but you need to put in the RHS f after every number you add
               else it will be syntax error for program*/


            #endregion

            #region Q4
            //Write C# program that Extract a substring from a given string.

            //string statment = "I'm Iron Man";
            //string substring = statment.Substring(1,6);
            //Console.WriteLine(substring);
            #endregion

            #region Q5
            /*Write C# program that Assigning one value type variable to another and modifying
              the value of one variable and mention what will happen*/

            //int x = 5;
            //int y = 6;

            //x = y;
            //Console.WriteLine(x);

            /* Clr will declare and allocate 4 bytes for each variable x and y in the stack
               then assign the value of y into x
               then print x and it will print 6*/

            #endregion

            #region Q6
            /*Write C# program that Assigning one reference type variable to another and modifying
              the object through one variable and mention what will happen*/

            //S s1 = new S() { x = 5, y = 5 };
            //S s2 = new S() { x = 4, y = 4 };

            //s1 = s2;

            //Console.WriteLine(s1.x);
            //Console.WriteLine(s1.y);

            /*declare two reference from type S 
              clr will allocate 4 bytes in the stack
              8 bytes will be allocated for each object s1 and s2 in the heap
              initialize the references s1 and s2 with default values
              assign the new values to each object
              then make s1 reference point the the s2 refrence in the heap*/

            #endregion

            #region Q7
            //Write C# program that take two string variables and print them as one variable

            //string s1 = "Hello";
            //string s2 = "World";

            //Console.WriteLine(s1 + " " +s2);
            #endregion

            #region Q8
            /*Write a program that calculates the simple interest given the principal amount,
              rate of interest, and time. The formula for simple interest is 
              Interest = (principal * rate * time) / 100.*/

            //Console.Write("Enter your princible : ");
            //double.TryParse(Console.ReadLine(), out double princible);
            //Console.Write("Enter your rate : ");
            //double.TryParse(Console.ReadLine(), out double rate);
            //Console.Write("Enter your time : ");
            //double.TryParse(Console.ReadLine(), out double time);

            //double interest = (princible * rate * time) / 100;

            //Console.WriteLine(interest);
            #endregion

            #region Q9
            /*Write a program that calculates the Body Mass Index(BMI) given a person's weight in kilograms
              and height in meters. The formula for BMI is
              BMI = (Weight) / (Height * Height)*/

            //Console.Write("Enter your weight : ");
            //double.TryParse(Console.ReadLine(), out double weight);
            //Console.Write("Enter your height : ");
            //double.TryParse(Console.ReadLine(), out double height);

            //double BMI = weight / (height * height);
            //Console.WriteLine(BMI);

            #endregion


            #region Q10
            /*Write a program that uses the ternary operator to check if the temperature is too hot,
              too cold, or just good. Assign the result in a variable then display the result..
              Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot",
              and anything else is "Just Good".*/

            //Console.WriteLine("Enter your temperature : ");
            //double.TryParse(Console.ReadLine(), out double temperature);

            //string message = (temperature < 10) ? "Just Cold" : ((temperature > 30) ? "Just Hot" : "Just Good");
            //Console.WriteLine(message);


            #endregion

            #region Q11

            string date = Console.ReadLine();
            string format = "dd/MM/yyyy";

            DateTime outDate;
            DateTime.TryParseExact(date, format,CultureInfo.InvariantCulture,DateTimeStyles.None,out outDate);

            Console.WriteLine($"Today’s date : {outDate: dd , MM , yyyy}");
            Console.WriteLine($"Today’s date : {outDate: dd / MM / yyyy}");
            Console.WriteLine($"Today’s date : {outDate: dd - MM - yyyy}");

            #endregion

            #region Q12

            // c) The event is on 06/14/2024
            #endregion

            #region Q13
            // f)A value 1 will be assigned to d.
            #endregion

            #region Q14
            // d)6 1
            #endregion

            #region Q15
            // d) 7 7
            #endregion
        }
    }
}
