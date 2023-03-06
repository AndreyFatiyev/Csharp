using System;


namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            //Напишите программу вычисляющую среднее арифметическое двух чисел

            double num1 = 0;
            double num2 = 0;

            Console.WriteLine("Enter first number : ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            double arithMean = (num1 + num2)/2;
            Console.WriteLine("arithmetic mean of numbers is " + arithMean);

        }
    }
}
