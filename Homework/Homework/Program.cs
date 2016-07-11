using System;


namespace Homework
{
   public class Program
    {
        static void Main(string[] args)
        {
            //add new employee
            //Console.WriteLine("Last Name:");
            //var lastName = Console.ReadLine();
            //Console.WriteLine("First Name:");
            //var firstName = Console.ReadLine();
            //Console.WriteLine("Date Of Birth:");
            //var dateOfBirth = DateTime.Parse( Console.ReadLine());
            //Console.WriteLine("Date of Employment:");
            //var dateOfEmployment = DateTime.Parse( Console.ReadLine());
            //Console.WriteLine("Salary:");
            //var salary = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Available Days Off:");
            //var availableDaysOff = Convert.ToInt32(Console.ReadLine());

            //var employeex = new Employee(lastName, firstName, dateOfBirth, salary, dateOfEmployment, availableDaysOff);


            var employee1 = new Employee("Marin", "Ionut", new DateTime(1994, 02, 09), 2300, new DateTime(2016,06,08), 30);
            var employee2 = new Employee("Grecu", "Marina", new DateTime(1985, 04, 12), 2300, new DateTime(2016, 4, 12), 5);

            employee1.DisplayInfo();
            employee2.DisplayInfo();

            //add new leave
            //Console.WriteLine("Starting date: ");
            //var startDate = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Duration: ");
            //var duration =Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Type Of Leave (medica/holiday/other): ");
            //LeaveType typeOfLeave; 
            //Enum.TryParse<LeaveType>(Console.ReadLine(),out typeOfLeave);

            var startDate = DateTime.Parse("2015-05-1");
            var duration = 5;
            var typeOfLeave = LeaveType.holiday;

            var startDate2 = DateTime.Parse("2016-05-1");
            var duration2 = 5;
            var typeOfLeave2 = LeaveType.holiday;


            Leave.employee = employee1;

            employee1.AddNewLeave(employee1, startDate, duration, typeOfLeave);
            employee1.AddNewLeave(employee1, startDate2, duration2, typeOfLeave2);
            employee1.DisplayList();

        }

        public enum LeaveType
        {
            medical,
            holiday,
            other
        }
    }
}
