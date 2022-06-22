using Dependencias.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencias.Clases
{
    public class ConsoleOutput : IOutput
    {
        public string Write(string content)
        {
            return content;
        }
    }
}
