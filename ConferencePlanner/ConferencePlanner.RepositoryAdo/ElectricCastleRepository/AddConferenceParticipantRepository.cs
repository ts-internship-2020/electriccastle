using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class AddConferenceParticipantRepository : IConferenceParticipant
    {
        private readonly SqlConnection _sqlConnection;

        public AddConferenceParticipantRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

       

        public void update(ConferenceParticipantModel conferenceParticipant)
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.Parameters.AddWithValue("@ConferenceId", conferenceParticipant.ConferenceId);
            sqlCommand.Parameters.AddWithValue("@ParticipantEmail", conferenceParticipant.EmailCode);
            sqlCommand.Parameters.AddWithValue("@EmailCode", conferenceParticipant.EmailCode);

            sqlCommand.CommandText = "UPDATE ConferenceParticipant set EmailCode=@EmailCode" +
                                       "where ParticipantEmail=@ParticipantEmail ";

            int rows = sqlCommand.ExecuteNonQuery();
        }
    }
}
