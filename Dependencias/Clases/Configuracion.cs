using Dependencias.Interfaces;
using System;

namespace Dependencias.Clases
{
    public class Configuracion : IConfig
    {
        public string FileWriterDestination { get; set; }
    }
}
