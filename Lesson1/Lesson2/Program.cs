using System;


namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Введите 3 числа и выведите на экран значение суммы и произведения этих чисел

            double num1, num2, num3;

            num1=Convert.ToDouble(Console.ReadLine());
            num2=Convert.ToDouble(Console.ReadLine());
            num3=Convert.ToDouble(Console.ReadLine());

            double summary   = num1 + num2 + num3;  
            double multiplic = num1 * num2 * num3;

            Console.WriteLine("summray of numbers : " + summary);
            Console.WriteLine("multiplication of numbers is :" + multiplic);

        }
    }
}
