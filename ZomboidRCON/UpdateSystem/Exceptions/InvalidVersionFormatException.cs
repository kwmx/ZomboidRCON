using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomboidRCON.UpdateSystem.Exceptions
{
    public class InvalidVersionFormatException : Exception
    {
        public InvalidVersionFormatException() : base("Provided an invalid version format")
        {
        }

        public InvalidVersionFormatException(string message)
            : base(message)
        {
        }

        public InvalidVersionFormatException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
