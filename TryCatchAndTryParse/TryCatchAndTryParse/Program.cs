using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAndTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool except = true;
            while (except)
            {

       
                int a = 0;
                int b = 0;

             

                try
                {   //Exception of num 1
                    bool except1 = true;
                    while (except1) {
                        try
                        {
                            Console.WriteLine("Enter first number : ");
                            a = Convert.ToInt32(Console.ReadLine());
                            except1 = false;
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Error ,enter number !\n");
                           
                            except1 = true;
                            
                        }
                    }

                    //Exception of num 2
                    bool except2 = true; 
                    while (except2)
                    {
                        try
                        {
                            Console.WriteLine("Enter second number : ");
                            b = Convert.ToInt32(Console.ReadLine());
                            except2 = false;
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Error ,enter number !\n");
                            
                            except2 = true;
                           
                        }

                    }
                        int result = a + b;

                        Console.WriteLine("Summary of numbers = " + result);

                       
                        except = false;

                   
                }

                catch (Exception)
                {

                    Console.WriteLine("Error ,put only numbers please !");
                    except = true;

                }

                Console.ReadKey();
            }
        }
        
    


    }
}
