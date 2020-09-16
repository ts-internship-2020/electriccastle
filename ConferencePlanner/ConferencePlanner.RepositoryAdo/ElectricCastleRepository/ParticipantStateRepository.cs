using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricRepository;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
   public  class ParticipantStateRepository : IDictionaryParticipantState
    {
        private readonly SqlConnection _sqlConnection;

        public ParticipantStateRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public List<ParticipantStateDemo> GetDictionaryParticipantStates(string email)
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.CommandText = "select cp.ConferenceId, dps.DictionaryParticipantStateId, dps.DictionaryParticipantStateName from ConferenceParticipant cp " +
                "join DictionaryParticipantState dps on cp.DictionaryParticipantStateId = dps.DictionaryParticipantStateId " +
                "where cp.ParticipantEmail = @email";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            
            List<ParticipantStateDemo> states = new List<ParticipantStateDemo>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    states.Add(new ParticipantStateDemo() 
                    {
                        ConferenceId = sqlDataReader.GetInt32("ConferenceId"),
                        StateId = sqlDataReader.GetInt32("DictionaryParticipantStateId"),
                        StateName = sqlDataReader.GetString("DictionaryParticipantStateName") });
                }
            }

            sqlDataReader.Close();

            return states;

        }

    }
}
