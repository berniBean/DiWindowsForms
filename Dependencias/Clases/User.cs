using Dependencias.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencias.Clases
{
    public class User : IUser
    {
        public string Login()
        {
            return "se ha logeado a un api";
        }
    }
}
