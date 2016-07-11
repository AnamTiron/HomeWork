
using System;

namespace Homework
{
    public class Person
    {
        protected string LastName;
        protected string FirstName;
        protected DateTime DateOfBirth;

        public Person(string lName, string fName, DateTime dBirth)
        {
            LastName = lName;
            FirstName = fName;
            DateOfBirth = dBirth;
        }
    }
}
