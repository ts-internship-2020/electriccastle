using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
//using ConferencePlanner.Abstraction.ParticipantRepository;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class ParticipantsConferencesRepository : IParticipantsConferencesRepository
    {
        private readonly SqlConnection  _sqlConnection;

        public ParticipantsConferencesRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public List<ParticipantsConferencesModel> GetParticipantsConferences()
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select c.ConferenceId, c.ConferenceName, c.StartDate, c.EndDate, dct.DictionaryConferenceTypeName," +
                " dcc.DictionaryConferenceCategoryName , dc.DictionaryCityName + ', ' + dcn.CountryCode AS Address, ds.DictionarySpeakerName, ds.DictionarySpeakerId, dps.DictionaryParticipantStateName" +
                " from Conference c " +
                " join Location l on l.LocationId = c.LocationId" +
                " join DictionaryCity dc on dc.DictionaryCityId = l.DictionaryCityId" +
                " join DictionaryDistrict dd on dd.DictionaryDistrictId = dc.DictionaryDistrictId" +
                " join DictionaryCountry dcn on dcn.DictionaryCountryId = dd.DictionaryCountryId" +
                " join DictionaryConferenceType dct on dct.DictionaryConferenceTypeId = c.DictionaryConferenceTypeId" +
                " join DictionaryConferenceCategory dcc on dcc.DictionaryConferenceCategoryId = c.DictionaryConferenceCategoryId" +
                " join ConferenceXDictionarySpeaker cds on cds.ConferenceId = c.ConferenceId" +
                " join DictionarySpeaker ds on ds.DictionarySpeakerId = cds.DictionarySpeakerId" +
                " join DictionaryParticipantState dps on dps.ParticipantStateCode = 'WDN'" +
                " where cds.IsMainSpeaker = 1";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<ParticipantsConferencesModel> participants = new List<ParticipantsConferencesModel>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    participants.Add(new ParticipantsConferencesModel() 
                        { ConferenceId = sqlDataReader.GetInt32("ConferenceId"),
                        Name = sqlDataReader.GetString("ConferenceName"),
                          StartDate = sqlDataReader.GetDateTime("StartDate"),
                          EndDate = sqlDataReader.GetDateTime("EndDate"),
                          ConferenceType = sqlDataReader.GetString("DictionaryConferenceTypeName"),
                          ConferenceCategory = sqlDataReader.GetString("DictionaryConferenceCategoryName"),
                          Address = sqlDataReader.GetString("Address"),
                          Speaker = sqlDataReader.GetString("DictionarySpeakerName"),
                          Id = sqlDataReader.GetInt32("DictionarySpeakerId"),
                        StateName = sqlDataReader.GetString("DictionaryParticipantStateName")
                    }
                    );
                }
            }



            sqlDataReader.Close();

            return participants;
        }

        public void UpdateParticipantsConferencesState(int index,int confeernceId, string email)
        {
           

            SqlCommand sqlCommand = _sqlConnection.CreateCommand();

            if(index == 7)
                sqlCommand.CommandText = "update ConferenceParticipant set DictionaryParticipantStateId  = 3 where ParticipantEmail = @Email ";

            if (index == 8)
                sqlCommand.CommandText = "update ConferenceParticipant set DictionaryParticipantStateId  = 1 where ParticipantEmail = @Email";

            if (index == 9)
                sqlCommand.CommandText = "update ConferenceParticipant set DictionaryParticipantStateId  = 2 where ParticipantEmail = @Email ";
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@Email", email);

            sqlCommand.Parameters.Add(parameters[0]);
            sqlCommand.ExecuteNonQuery();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //sqlDataReader.Close();


        }
    }
}
