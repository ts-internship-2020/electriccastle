using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class SpeakerRepository : ISpeakerRepository
    {
        private readonly SqlConnection _sqlConnection;

        public SpeakerRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public List<SpeakerModel> GetSpeaker()
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select ds.DictionarySpeakerId, ds.SpeakerCode, ds.DictionarySpeakerName, ds.Rating, ds.Nationality, ds.Picture" +
                " from DictionarySpeaker ds";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<SpeakerModel> speakers = new List<SpeakerModel>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    speakers.Add(new SpeakerModel()
                    {
                        Id = sqlDataReader.GetInt32("DictionarySpeakerId"),
                        Code = sqlDataReader.GetString("SpeakerCode"),
                        Name = sqlDataReader.GetString("DictionarySpeakerName"),
                        Rating = sqlDataReader.GetDecimal("Rating"),
                        Nationality = sqlDataReader.GetString("Nationality"),
                        Picture = sqlDataReader.GetString("Picture")
                    }
                    );
                }
            }

            sqlDataReader.Close();

            return speakers;
        }
    }
}
