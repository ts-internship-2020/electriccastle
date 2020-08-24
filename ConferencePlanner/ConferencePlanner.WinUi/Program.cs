using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.ParticipantRepository;
using ConferencePlanner.Abstraction.Repository;
using ConferencePlanner.Repository.Ado.ElectricCastleRepository;
using ConferencePlanner.Repository.Ado.ParticipantsConferencesRepository;
using ConferencePlanner.Repository.Ado.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConferencePlanner.WinUi
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();

            Application.Run(ServiceProvider.GetService<StartScreen>());
               //Application.Run(new StartScreen());
           // Application.Run(new FormTestDataBase());
        }


        public static IServiceProvider ServiceProvider { get; set; }

        public static class MyParticipants
        {
            public static List<String> EmailParticipants;
        }

        static void ConfigureServices()
        {
            // Ich bin very poliglotten
            var services = new ServiceCollection();
            services.AddScoped<MainForm>();
            services.AddScoped<MainScreen>();
            services.AddScoped<StartScreen>();

            services.AddScoped<IGetDemoRepository, GetDemoRepository>();
            services.AddScoped<IParticipantsConferencesRepository, ParticipantsConferencesRepository>();
            services.AddSingleton<SqlConnection>(a =>
            {
                SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
                sqlConnection.Open();
                return sqlConnection;
            });
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
