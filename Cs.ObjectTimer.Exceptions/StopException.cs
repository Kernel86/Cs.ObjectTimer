/*************************
 * [StopException.cs]
 * C# Intermediate
 * Shawn Novak
 * 2012-10-24
 *************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cs.ObjectTimer.Exceptions
{
    public class StopException : System.Exception
    {
    // Constructors
        public StopException() : base("Exception - Clock is not running.")
        {
        }

        public StopException(string message) : base(message)
        {
        }
    }
}
