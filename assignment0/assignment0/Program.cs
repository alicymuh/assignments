using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment0
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.firstName = "Bel";
            s1.lastName = "Mij";
            s1.City = "Seattle";
            s1.birthdate = new DateTime(1997, 3, 9).Date;

            Student s2 = new Student("Blp", "Nui", "Redmond", new DateTime(1990, 3, 9));

            Console.WriteLine("Student details {0}", s1);
            Console.WriteLine("Student details {0}", s2);
            Console.ReadLine();
        }
    }
}
