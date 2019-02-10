using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;
            Console.WriteLine("Enter the first number :");            
            try
            {
                num1 = Int32.Parse(Console.ReadLine());
                
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not an int");
                return;
            }
            Console.WriteLine("Enter the second number :");
            try
            {
                num2 = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not an int");
            }
            result = Divide(num1,num2);
            
            Console.WriteLine("The result is {0}", result);
            Console.ReadLine();
        }

        static int Divide(int num1, int num2)
        {
            int result = 0;
            int i = 0;
           
                try
                {
                    result = num1 / num2;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error, can't divide by zero");
                }
                catch (Exception e)
                {
                Console.WriteLine("an error occured");
                }
                      
            return result;

        }
    }
}
