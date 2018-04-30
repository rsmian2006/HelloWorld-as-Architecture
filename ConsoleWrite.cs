using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class ConsoleWrite : IWrite
    {
        public string Write(string val)
        {
            return val;
        }
    }
}
