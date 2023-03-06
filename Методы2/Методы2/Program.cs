namespace MyApp;
using System;
class Program
{
    static string GetLastHalf(string a)
    {
       int b = a.Length / 2;
        a = a.Substring(b);
        a = a.Replace("", " ");   
        return a;
    }
    static void Main(string[] arghs)
    {




        Console.WriteLine(GetLastHalf("I love CSharp!"));
        Console.WriteLine(GetLastHalf("1234567890"));
        Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));






    }
}