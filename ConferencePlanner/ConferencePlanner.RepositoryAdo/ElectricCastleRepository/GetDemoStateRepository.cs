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

            sqlCommand.CommandText = "select DictionaryParticipantStateName from DictionaryParticipantState";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //SqlTransaction transaction;
            //transaction = _sqlConnection.BeginTransaction("SampleTransaction");
            //sqlCommand.Connection = _sqlConnection;
            //sqlCommand.Transaction = transaction;

            //try
            //{
               
            //    sqlCommand.ExecuteNonQuery();
            //    transaction.Commit();
            //    Console.WriteLine("Records are written to database.");

            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

               
            //}
            
            List<ParticipantStateDemo> demosState = new List<ParticipantStateDemo>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    demosState.Add(new ParticipantStateDemo() { State = sqlDataReader.GetString("DictionaryParticipantStateName") });
                }
            }

            //sqlCommand.CommandText = "update DictionaryParticipantState set DictionaryParticipantStateName=demosState.State";

            sqlDataReader.Close();

            return demosState;

        }

        public void updateState(string email)
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();

            sqlCommand.CommandText = "update ConferenceParticipant set DictionaryParticipantStateId=1 where ParticipantEmail ='email'";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        }
    }
}
