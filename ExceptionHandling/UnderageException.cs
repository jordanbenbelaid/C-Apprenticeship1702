using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class UnderageException : Exception
    {
        public UnderageException() : base("Age is too young") { }

        public UnderageException(string message) : base(message) { }
    }
}
