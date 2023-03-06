
namespace MyApp
{
    class Program
    {
        static string GetGreetingMessage(string name, double salary)
        {
            int salaryCeiling = (int)Math.Ceiling(salary);
            string c = Convert.ToString(salaryCeiling);
            return ("Hello,"+name+" your salary is "+c);
        }
        static void Main(string[] args)
        {

            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));



        }
    }
}
