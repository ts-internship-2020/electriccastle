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
            SqlTransaction transaction;
            transaction = _sqlConnection.BeginTransaction("SampleTransaction");
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.Transaction = transaction;

            try
            {
                sqlCommand.CommandText = "select state from ParticipantStateDemo";
                sqlCommand.ExecuteNonQuery();
                transaction.Commit();
                Console.WriteLine("Records are written to database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);


                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }

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
