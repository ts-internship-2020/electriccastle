using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.Repository;
using ConferencePlanner.Repository.Ado.ElectricCastleRepository;

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
          // Application.Run(new AddConferance());

        }


        public static IServiceProvider ServiceProvider { get; set; }

       public static String EmailParticipants;




        static void ConfigureServices()
        {
            // Ich bin very poliglotten
            var services = new ServiceCollection();

            services.AddScoped<TestareFctButoane>();
            services.AddScoped<IDictionaryParticipantState, GetDemoStateRepository>();

            services.AddScoped<MainForm>();
            services.AddScoped<MainScreen>();
            services.AddScoped<StartScreen>();
            services.AddScoped<SpeakerForm>();

            services.AddScoped<IGetDemoRepository, GetSpeakerDetail>();
            services.AddScoped<IParticipantsConferencesRepository, ParticipantsConferencesRepository>();
            services.AddScoped<IOrganizerConferencesRepository, OrganizerConferencesRepository>();
            services.AddScoped<ISpeakerDetailRepository, SpeakerDetailRepository>();
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

