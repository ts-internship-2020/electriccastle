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

        public void deleteSpeaker( int speakerId)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", speakerId);
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"delete from DictionarySpeaker where DictionarySpeakerId = @Id;";
            sqlCommand.Parameters.Add(parameters[0]);
            int nr = sqlCommand.ExecuteNonQuery();
        }

        public void editSpeaker(int speakerId, string speakerCode, string speakerName, decimal speakerRating, string speakerNationality, string speakerPicture)
        {
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@Id", speakerId);
            parameters[1] = new SqlParameter("@Code", speakerCode);
            parameters[2] = new SqlParameter("@Name", speakerName);
            parameters[3] = new SqlParameter("@Rating", speakerRating);
            parameters[4] = new SqlParameter("@Nationality", speakerNationality);
            parameters[5] = new SqlParameter("@Picture", speakerPicture);

            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"update DictionarySpeaker set SpeakerCode = @Code, DictionarySpeakerName = @Name, Rating = @Rating, Nationality = @Nationality, Picture = @Picture where DictionarySpeakerId = @Id;";
            sqlCommand.Parameters.Add(parameters[0]);
            sqlCommand.Parameters.Add(parameters[1]);
            sqlCommand.Parameters.Add(parameters[2]);
            sqlCommand.Parameters.Add(parameters[3]);
            sqlCommand.Parameters.Add(parameters[4]);
            sqlCommand.Parameters.Add(parameters[5]);

            int nr = sqlCommand.ExecuteNonQuery();
        }

        public void addSpeaker(int speakerId, string speakerCode, string speakerName, decimal speakerRating, string speakerNationality, string speakerPicture)
        {
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@Id", speakerId);
            parameters[1] = new SqlParameter("@Code", speakerCode);
            parameters[2] = new SqlParameter("@Name", speakerName);
            parameters[3] = new SqlParameter("@Rating", speakerRating);
            parameters[4] = new SqlParameter("@Nationality", speakerNationality);
            parameters[5] = new SqlParameter("@Picture", speakerPicture);

            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"insert into DictionarySpeaker ds values(@Id,@Code,@Name,@Rating,@Nationality,@Picture)";
            sqlCommand.Parameters.Add(parameters[0]);
            sqlCommand.Parameters.Add(parameters[1]);
            sqlCommand.Parameters.Add(parameters[2]);
            sqlCommand.Parameters.Add(parameters[3]);
            sqlCommand.Parameters.Add(parameters[4]);
            sqlCommand.Parameters.Add(parameters[5]);

            int nr = sqlCommand.ExecuteNonQuery();
        }
    }
}
