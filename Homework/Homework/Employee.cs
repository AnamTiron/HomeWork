using Homework;
using System;
using System.Collections.Generic;
using  static Homework.Program;


namespace Homework
{
   public class Employee: Person
    {
        public DateTime DateOfEmployment;
        public int Salary;
        public int AvailableDaysOff;

        public Employee(string lName, string fName, DateTime dBirth, int salary, DateTime dateOfEmployment, int availableDaysOff) : base(lName, fName, dBirth)
        {
           // LastName = lName;
           // FirstName = fName;
           // DateOfBirth = dBirth;
            Salary = salary;
            if (dBirth < dateOfEmployment)  //asa pot angaja numai oameni care s-au nascut deja :)
            {
                DateOfEmployment = dateOfEmployment;
            }
            AvailableDaysOff = availableDaysOff;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Last Name: {0}",LastName);
            Console.WriteLine("First Name: {0}", FirstName);
            Console.WriteLine("Salary: {0}", Salary);
            Console.WriteLine("Available Days Off: {0}",AvailableDaysOff);
        }

        private int SubstractDays(int duration)
        {

            AvailableDaysOff -= duration;
            return AvailableDaysOff;
            
        }

        List<Leave> LeaveList = new List<Leave>();

        public void AddNewLeave(Employee employee, DateTime date, int duration, LeaveType leaveT)
        {


            Leave.employee = employee;
            var leave = new Leave(date, duration, leaveT);
            
            
            LeaveList.Add(new Leave() {startingDate=date, duration=duration, leaveType=leaveT });

            if (!(leaveT.Equals("medical")))
            {
                if (duration < AvailableDaysOff )
                {
                    employee.AvailableDaysOff = SubstractDays(duration);
                }
                else
                {
                    throw new NegativeLeaveDays("you don't have that many days left");
                }
            }
        }


        
            public void DisplayList()
        {
            Console.WriteLine("Lista de concedii ale lui {0} {1}  :", Leave.employee.LastName, Leave.employee.FirstName); 
            foreach (Leave l in LeaveList)
            {
                Console.WriteLine("duration: "+ l.duration+" /starting date: " +l.startingDate+" /Type of leave: " +l.leaveType);
            }
        }

            



        

}
}


