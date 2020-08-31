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
            sqlCommand.CommandText = "SELECT ConferenceId, ConferenceName, OrganizerEmail, OrganizerName," +
                                     " StartDate, EndDate, DictionaryConferenceCategoryId, DictionaryConferenceTypeId," +
                                     " LocationId FROM Conference" +
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
                        LocationId = sqlDataReader.GetInt32("LocationId")
                    };
                }
            }
            sqlDataReader.Close();

            // + cod pentru luat din celelalte tabele

            return conference;
        }
    }
}
