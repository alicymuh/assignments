using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment0
{
    class Student
    {
        public string firstName
        { get; set; }
        public string lastName
        { get; set; }        
        public string City
        { get; set; }
        public DateTime birthdate
        { get; set; }

        public Student(string firstName, string lastName, string City, DateTime birthdate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.City = City;
            this.birthdate = birthdate;
        }

        public Student()
        {

        }

        public override string ToString()
        {
            return "firstName = " + firstName + ", lastName = " + lastName + ",City = "+ City +", birthdate = " + birthdate;

        }
    }
}
