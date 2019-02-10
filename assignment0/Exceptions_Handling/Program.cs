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
            num1 = readLine(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            num2 = readLine(Console.ReadLine());
            result = Divide(num1, num2);
            Console.ReadLine();
        }

        static int Divide(int num1, int num2)
        {
            int result = 0;
            try
                {
                    result = num1 / num2;
                    Console.WriteLine("The result is {0}", result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error, can't divide by zero");                
                }
                catch (Exception e)
                {
                Console.WriteLine("{0} Exception caught.", e);
                }
                      
            return result;

        }

        static int readLine(String s)
        {
            int numValue = 0;
            bool parsed = Int32.TryParse(s, out numValue);

            if (!parsed)           
                Console.WriteLine("Int32.TryParse could not parse '{0}' to an int.\n", s);              
            
            return numValue;


        }
    }
}
