using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Extended
{
    internal class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)//Adapter design pattern
        {
            Console.WriteLine(message);
        }
    }
}
