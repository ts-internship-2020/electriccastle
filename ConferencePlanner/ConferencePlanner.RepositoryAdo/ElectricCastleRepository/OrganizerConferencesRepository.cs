using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class OrganizerConferencesRepository : IOrganizerConferencesRepository
    {

        private readonly SqlConnection _sqlConnection;

        public OrganizerConferencesRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public List<OrganizerConferencesModel> GetConferencesForOrganizer(string email)
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.CommandText = "select c.ConferenceId, c.ConferenceName, c.StartDate, c.EndDate, dct.DictionaryConferenceTypeName," +
                " dcc.DictionaryConferenceCategoryName , dc.DictionaryCityName + ', ' + dcn.CountryCode AS Adress, ds.DictionarySpeakerName" +
                " from Conference c " +
                " join Location l on l.LocationId = c.LocationId" +
                " join DictionaryCity dc on dc.DictionaryCityId = l.DictionaryCityId" +
                " join DictionaryDistrict dd on dd.DictionaryDistrictId = dc.DictionaryDistrictId" +
                " join DictionaryCountry dcn on dcn.DictionaryCountryId = dd.DictionaryCountryId" +
                " join DictionaryConferenceType dct on dct.DictionaryConferenceTypeId = c.DictionaryConferenceTypeId" +
                " join DictionaryConferenceCategory dcc on dcc.DictionaryConferenceCategoryId = c.DictionaryConferenceCategoryId" +
                " join ConferenceXDictionarySpeaker cds on cds.ConferenceId = c.ConferenceId" +
                " join DictionarySpeaker ds on ds.DictionarySpeakerId = cds.DictionarySpeakerId" +
                " where cds.IsMainSpeaker = 1" +
                " and c.OrganizerEmail = @email";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<OrganizerConferencesModel> conferences = new List<OrganizerConferencesModel>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    conferences.Add(new OrganizerConferencesModel()
                    {
                        ConferenceId = sqlDataReader.GetInt32("ConferenceId"),
                        ConferenceName = sqlDataReader.GetString("ConferenceName"),
                        StartDate = sqlDataReader.GetDateTime("StartDate"),
                        EndDate = sqlDataReader.GetDateTime("EndDate"),
                        ConferenceType = sqlDataReader.GetString("DictionaryConferenceTypeName"),
                        ConferenceCategory = sqlDataReader.GetString("DictionaryConferenceCategoryName"),
                        Adress = sqlDataReader.GetString("Adress"),
                        MainSpeaker = sqlDataReader.GetString("DictionarySpeakerName")
                    });
                }
            }

            sqlDataReader.Close();

            return conferences;
        }
    }
}
