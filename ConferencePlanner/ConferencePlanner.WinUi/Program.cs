using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.Repository;
using ConferencePlanner.Repository.Ado.ElectricCastleRepository;
using ConferencePlanner.Repository.Ado.Repository;
using ConferencePlanner.Repository.Ef.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
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
          // Application.Run(ServiceProvider.GetService<AddConferance>());

          // Application.Run(new AddConferance());

        }


        public static IServiceProvider ServiceProvider { get; set; }

       public static  String EmailParticipants;




        static void ConfigureServices()
        {
            // Ich bin very poliglotten
            var services = new ServiceCollection();

          
            services.AddScoped<IDictionaryParticipantState, GetDemoStateRepository>();

            services.AddScoped<MainScreen>();
            services.AddScoped<StartScreen>();
            services.AddScoped<AddConferance>();
            services.AddScoped<SpeakerForm>();
            services.AddScoped<NewCountryForm>();
            services.AddScoped<NewDistrictForm>();
            services.AddScoped<NewCityForm>();
            services.AddScoped<NewConferanceType>();
            services.AddScoped<AddEditConferenceCategoryScreen>();
            services.AddScoped<EditSpeakerForm>();
            services.AddScoped<AddSpeakerForm>();

            services.AddScoped<IParticipantsConferencesRepository, ParticipantsConferencesRepository>();
            services.AddScoped<IOrganizerConferencesRepository, Repository.Ado.ElectricCastleRepository.OrganizerConferencesRepository>();
            services.AddScoped<IConferanceCategory, ConferanceCategoryRepository>();
            services.AddScoped<ISpeakerDetailRepository, Repository.Ado.ElectricCastleRepository.SpeakerDetailRepository>();
            services.AddScoped<IConferenceCategoryRepository, ConferenceCategoryRepository>();
            services.AddScoped<IAddConferenceCityRepository, AddConferenceCityRepository>();
            services.AddScoped<IAddConferenceCountryRepository, GetCountryRepositoryEntFr>();
            services.AddScoped<IAddConferenceDistrictRepository, AddConferenceDistrictRepository>();
            services.AddScoped<IEmailParticipant, InsertEmailParticipant>();
            services.AddScoped<IConferenceTypeRepository, ConferenceTypeRepository>();
            services.AddScoped<IAddConferenceCountryRepository, AddConferenceCountryRepository>();

            services.AddScoped<ISpeakerRepository, SpeakerRepository>();
            services.AddScoped<IConferenceTypeRepository, ConferenceTypeRepository>();
            services.AddScoped<IConferenceRepository, Repository.Ado.ElectricCastleRepository.ConferenceRepository>();
           

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

