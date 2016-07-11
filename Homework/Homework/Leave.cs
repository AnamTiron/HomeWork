using System;
using System.Collections;
using System.Collections.Generic;
using static Homework.Program;

namespace Homework
{

    
    public class Leave
    {
       public DateTime startingDate;
       public int duration;
       public LeaveType leaveType;
       public static Employee employee;

        public Leave()
        {
        }

        public Leave(DateTime startDate, int dur, LeaveType leaveT)
        {
            startingDate = startDate;
            duration = dur;
            leaveType = leaveT;
        }
        public Leave(Employee employee, DateTime startDate, int dur, LeaveType leaveT) { }

       
    }
}
