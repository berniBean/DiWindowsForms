using Dependencias.Interfaces;
using System;

namespace Dependencias.Clases
{
    public class TodayWriter : IDateWriter
    {
        private IOutput _output;

        public TodayWriter(IOutput output)
        {
            _output = output;
        }
        public void WriteDate()
        {
            _output.Write(DateTime.Today.ToShortDateString());
        }
    }
}
