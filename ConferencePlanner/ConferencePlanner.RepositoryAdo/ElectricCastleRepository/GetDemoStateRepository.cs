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
   public  class GetDemoStateRepository : IDictionaryParticipantState
    {
        private readonly SqlConnection _sqlConnection;

        public GetDemoStateRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public List<ParticipantStateDemo> GetDictionaryParticipantStates(string state)
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select state from ParticipantStateDemo";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<ParticipantStateDemo> demos = new List<ParticipantStateDemo>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    demos.Add(new ParticipantStateDemo() {state = sqlDataReader.GetString("state") });
                }
            }

            sqlDataReader.Close();

            return demos;
        }
    }
}
