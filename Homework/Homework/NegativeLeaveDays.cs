using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class NegativeLeaveDays : Exception
    {
        public NegativeLeaveDays()
        {
        }

        public NegativeLeaveDays(string message)
           : base(message)
        {
        }
        //public NegativeLeaveDays(string message, System.Exception innerException): base(message, innerException)
        //{
        //}
       
    }
}
