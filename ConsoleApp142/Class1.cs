using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp142
{
   public class NegativeNumberException:Exception
    {
        public NegativeNumberException() : base("Illegal operation for a negative number")
        {
            //empty body
        }

        public NegativeNumberException(string messageValue) : base(messageValue)
        {
            //empty body
        }

        public NegativeNumberException(string messageValue, Exception inner) : base(messageValue, inner)
        {
            //empty body
        }
    }
}
