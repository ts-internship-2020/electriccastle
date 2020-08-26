using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class SpeakerDetailRepository : ISpeakerDetailRepository
    {
        private readonly SqlConnection _sqlConnection;

        public SpeakerDetailRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public List<SpeakerDetailModel> GetSpeakerDetail()
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select ds.DictionarySpeakerName, ds.Rating, ds.Nationality" +
                " from Conference c " +
                " join ConferenceXDictionarySpeaker cds on cds.ConferenceId = c.ConferenceId" +
                " join DictionarySpeaker ds on ds.DictionarySpeakerId = cds.DictionarySpeakerId" +
                " where cds.IsMainSpeaker = 1";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<SpeakerDetailModel> details = new List<SpeakerDetailModel>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    details.Add(new SpeakerDetailModel()
                    {
                        Name = sqlDataReader.GetString("DictionarySpeakerName"),
                        Rating = sqlDataReader.GetDecimal("Rating"),
                        Nationality = sqlDataReader.GetString("Nationality")
                        //Picture = sqlDataReader.GetString("Picture")
                    }
                    );
                }
            }

            sqlDataReader.Close();

            return details;
        }
    }
}
