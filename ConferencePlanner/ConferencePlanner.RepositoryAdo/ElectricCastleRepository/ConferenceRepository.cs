using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Diagnostics;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class ConferenceRepository : IConferenceRepository
    {
        private readonly SqlConnection _sqlConnection;

        public ConferenceRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public void AddConference(ConferenceModel conference)
        {
            try
            {
                SqlCommand sqlCommand = _sqlConnection.CreateCommand();
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.Parameters.AddWithValue("@ConferenceName", conference.ConferenceName);
                sqlCommand.Parameters.AddWithValue("@OrganizerEmail", conference.OrganizerEmail);
                sqlCommand.Parameters.AddWithValue("@OrganizerName", conference.OrganizerName);
                sqlCommand.Parameters.AddWithValue("@StartDate", conference.StartDate);
                sqlCommand.Parameters.AddWithValue("@EndDate", conference.EndDate);
                sqlCommand.Parameters.AddWithValue("@DictionaryConferenceCategoryId", conference.DictionaryConferenceCategoryId);
                sqlCommand.Parameters.AddWithValue("@DictionaryConferenceTypeId", conference.DictionaryConferenceTypeId);
                sqlCommand.Parameters.AddWithValue("@LocationId", conference.LocationId);
                sqlCommand.CommandText = "INSERT INTO Conference(ConferenceName, OrganizerEmail, OrganizerName," +
                                         " StartDate, EndDate, DictionaryConferenceCategoryId, DictionaryConferenceTypeId, LocationId) " +
                                         " VALUES(@ConferenceName, @OrganizerEmail, @OrganizerName, @StartDate, @EndDate," +
                                         " @DictionaryConferenceCategoryId, @DictionaryConferenceTypeId, @LocationId)";

                int rowsAdded = sqlCommand.ExecuteNonQuery();

                //SqlCommand sqlCommandSpeakers = _sqlConnection.CreateCommand();
                //sqlCommandSpeakers.Connection = _sqlConnection;
                //sqlCommandSpeakers.Transaction = sqlTransaction;
                //sqlCommandSpeakers.Parameters.Add(new SqlParameter("@key", SqlDbType.NChar));
                //sqlCommandSpeakers.Parameters.Add(new SqlParameter("@value", SqlDbType.NChar));
                //sqlCommandSpeakers.CommandText = "INSERT INTO [Setting] ([Key], [Value]) VALUES (@key, @value);";
                //using (SqlTransaction sqlTransaction = _sqlConnection.BeginTransaction())
                //{
                //    try
                //    {
                //        foreach (var oSetting in settings)
                //        {
                //            sqlCommandSpeakers.Parameters[0].Value = oSetting.Key;
                //            sqlCommandSpeakers.Parameters[1].Value = oSetting.Value;
                //            if (sqlCommandSpeakers.ExecuteNonQuery() != 1)
                //            {
                //                //'handled as needed, 
                //                //' but this snippet will throw an exception to force a rollback
                //                throw new InvalidProgramException();
                //            }
                //        }
                //        sqlTransaction.Commit();
                //    }
                //    catch (Exception)
                //    {
                //        sqlTransaction.Rollback();
                //        throw;
                //    }
                //}
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            // + cod pentru insert in celelalte tabele
        }

        public void DeleteConference(int conferenceId)
        {
            throw new NotImplementedException();
        }

        public void EditConference(ConferenceModel conference)
        {
            try
            {
                SqlCommand sqlCommand = _sqlConnection.CreateCommand();
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.Parameters.AddWithValue("@ConferenceName", conference.ConferenceName);
                sqlCommand.Parameters.AddWithValue("@OrganizerEmail", conference.OrganizerEmail);
                sqlCommand.Parameters.AddWithValue("@OrganizerName", conference.OrganizerName);
                sqlCommand.Parameters.AddWithValue("@StartDate", conference.StartDate);
                sqlCommand.Parameters.AddWithValue("@EndDate", conference.EndDate);
                sqlCommand.Parameters.AddWithValue("@DictionaryConferenceCategoryId", conference.DictionaryConferenceCategoryId);
                sqlCommand.Parameters.AddWithValue("@DictionaryConferenceTypeId", conference.DictionaryConferenceTypeId);
                sqlCommand.Parameters.AddWithValue("@LocationId", conference.LocationId);
                sqlCommand.CommandText = "UPDATE Conference" +
                                         " SET ConferenceName = @ConferenceName," +
                                            " OrganizerEmail = @OrganizerEmail," +
                                            " OrganizerName = @OrganizerName," +
                                            " StartDate = @StartDate," +
                                            " EndDate = @EndDate," +
                                            " DictionaryConferenceCategoryId = @DictionaryConferenceCategoryId," +
                                            " DictionaryConferenceTypeId = @DictionaryConferenceTypeId," +
                                            " LocationId = @LocationId)";

                int rowsEdited = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public ConferenceModel GetConference(int conferenceId)
        {

            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.Parameters.AddWithValue("@ConferenceId", conferenceId);
            sqlCommand.CommandText = "SELECT C.ConferenceId, C.ConferenceName, C.OrganizerEmail, C.OrganizerName," +
                                    " C.StartDate, C.EndDate, C.DictionaryConferenceCategoryId, C.DictionaryConferenceTypeId," +
                                    " C.LocationId, L.AdressDetails, DC.DictionaryCityId, DD.DictionaryDistrictId," +
                                    " DCN.DictionaryCountryId FROM Conference C" +
                                    " JOIN Location L ON C.LocationId = L.LocationId" +
                                    " JOIN DictionaryCity DC ON DC.DictionaryCityId = L.DictionaryCityId" +
                                    " JOIN DictionaryDistrict DD ON DD.DictionaryDistrictId = DC.DictionaryDistrictId" +
                                    " JOIN DictionaryCountry DCN ON DCN.DictionaryCountryId = DD.DictionaryCountryId" +
                                    " WHERE ConferenceId = @ConferenceId";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(); 
            
            ConferenceModel conference = null;

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    conference = new ConferenceModel
                    {
                        ConferenceId = sqlDataReader.GetInt32("ConferenceId"),
                        ConferenceName = sqlDataReader.GetString("ConferenceName"),
                        OrganizerEmail = sqlDataReader.GetString("OrganizerEmail"),
                        OrganizerName = sqlDataReader.GetString("OrganizerName"),
                        StartDate = sqlDataReader.GetDateTime("StartDate"),
                        EndDate = sqlDataReader.GetDateTime("EndDate"),
                        DictionaryConferenceCategoryId = sqlDataReader.GetInt32("DictionaryConferenceCategoryId"),
                        DictionaryConferenceTypeId = sqlDataReader.GetInt32("DictionaryConferenceTypeId"),
                        LocationId = sqlDataReader.GetInt32("LocationId"),
                        AdressDetails = sqlDataReader.GetString("AdressDetails"),
                        DictionaryCityId = sqlDataReader.GetInt32("DictionaryCityId"),
                        DictionaryDistrictId = sqlDataReader.GetInt32("DictionaryDistrictId"),
                        DictionaryCountryId = sqlDataReader.GetInt32("DictionaryCountryId")
                    };
                }
            }

            sqlDataReader.Close();

            SqlCommand sqlCommandSpeakers = _sqlConnection.CreateCommand();
            sqlCommandSpeakers.Connection = _sqlConnection;
            sqlCommandSpeakers.Parameters.AddWithValue("@ConferenceId", conferenceId);
            sqlCommandSpeakers.CommandText = "SELECT DictionarySpeakerId, ConferenceId, IsMainSpeaker" +
                                            " FROM ConferenceXDictionarySpeaker" +
                                            " WHERE ConferenceId = @ConferenceId; ";

            SqlDataReader sqlDataReaderSpeakers = sqlCommandSpeakers.ExecuteReader();

            conference.Speakers = new List<SpeakerListModel>();

            if (sqlDataReaderSpeakers.HasRows)
            {
                while (sqlDataReaderSpeakers.Read())
                {
                    conference.Speakers.Add(new SpeakerListModel
                    {
                        DictionarySpeakerId = sqlDataReaderSpeakers.GetInt32("DictionarySpeakerId"),
                        IsMainSpeaker = sqlDataReaderSpeakers.GetBoolean("IsMainSpeaker")
                    });
                }
            }

            sqlDataReaderSpeakers.Close();

            return conference;
        }
    }
}
