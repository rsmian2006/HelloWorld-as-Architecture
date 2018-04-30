using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class DataBaseWrite : IWrite
    {
        public string Write(string val)
        {
           //ADO.NET, Azure, ORM (etc.) code to write "Hello World" to the database
            return string.Empty;
        }
    }
}
