using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1
{
    internal class invalidCustomer : Exception
    {
        public invalidCustomer(string message) : base(message)
        {

        }
    }

    internal class invalidDateException : Exception
    {
        public invalidDateException(string message) : base(message)
        {

        }
    }


}
