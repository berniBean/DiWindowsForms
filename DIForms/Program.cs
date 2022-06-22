using Dependencias.Clases;
using Dependencias.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIForms
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static IServiceProvider BuildServiceProvider()
        {
            IServiceCollection collection = new ServiceCollection();

            IConfiguration configuracion = new ConfigurationBuilder()
                .AddJsonFile("appSetting.json", optional: false)
                .Build();

            IConfig config = configuracion.Get<Configuracion>();
            collection.AddSingleton<IConfig>(config);

            return collection.BuildServiceProvider();

        }
    }


}
