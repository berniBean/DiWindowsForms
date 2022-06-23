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
            

            var services = new ServiceCollection();
            BuildServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }
        static void BuildServices(ServiceCollection services)
        {
            services.AddScoped<IUser, User>()
                .AddScoped<Form1>();
            services.AddScoped<IOutput, ConsoleOutput>()
                .AddScoped<Form1>();
            services.AddScoped<IDateWriter, TodayWriter>()
                .AddScoped<Form1>();
        }
        //static IServiceProvider BuildServiceProvider()
        //{
        //    IServiceCollection collection = new ServiceCollection();

        //    IConfiguration configuracion = new ConfigurationBuilder()
        //        .AddJsonFile("appSetting.json", optional: false)
        //        .Build();

        //    IConfig config = configuracion.Get<Configuracion>();
        //    collection.AddSingleton<IConfig>(config);

        //    return collection.BuildServiceProvider();

        //}
    }


}
