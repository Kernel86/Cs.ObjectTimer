/*************************
 * [StartException.cs]
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
    public class StartException : System.Exception
    {
    // Constructors
        public StartException() : base("Exception - Clock has already started.")
        {
        }

        public StartException(string message) : base(message)
        {
        }
    }
}
