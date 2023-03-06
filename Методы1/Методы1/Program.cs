namespace MyApp
{
    class Program
    {
       
        static int GetSquare(int a)
        {
            int b = a * a;
            return b;

        }
        static string Print(int b)
        {
            string c = Convert.ToString(b);
            string d = ("Squade of the number  = 42 is  ");
            return (d+b );

        }

        static void Main(string[] arghs)
        {            
         
           string SquadOfTheNum = Print(GetSquare(42));
            Console.WriteLine(SquadOfTheNum);


        }
    }
}