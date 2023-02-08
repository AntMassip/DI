using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.LateBinding
{
    internal interface IMessageWriter
    {
        void Write(string message);
    }
}
