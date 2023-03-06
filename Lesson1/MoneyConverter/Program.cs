using System;
using System.Globalization;

namespace MoneyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Напишите конвертер валют (без возможности динамического выбора валюты пользователем).
            double usd = 0.59, euro = 0.55, rub = 44.35, azn;
           
           

            Console.WriteLine("enter quantity of money for convert : ");
            string quanti = Console.ReadLine();
         
            bool result = double.TryParse(quanti,out azn);
           
            Console.WriteLine("RUB is : " + (rub*azn) + "\nUSD is : " + (usd*azn) + "\nEURO is :" + (euro*azn));
          
       
           








        }
    }
}
