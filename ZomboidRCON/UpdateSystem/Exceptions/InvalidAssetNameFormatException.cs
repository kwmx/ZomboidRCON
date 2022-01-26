using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomboidRCON.UpdateSystem.Exceptions
{
    public class InvalidAssetNameFormatException : Exception
    {
        public InvalidAssetNameFormatException() : base("Invalid asset name. The name has to end with .zip and contain the replacement files intented for update")
        {
        }

        public InvalidAssetNameFormatException(string message)
            : base(message)
        {
        }

        public InvalidAssetNameFormatException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
