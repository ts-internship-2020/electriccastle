using ConferencePlanner.Abstraction.Model;
using ConferencePlanner.Abstraction.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ConferencePlanner.Repository.Ado.Repository
{
    public class GetDemoRepository : IGetDemoRepository
    {
        private readonly SqlConnection _sqlConnection;

        public GetDemoRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public List<DemoModel> GetDemo(string name)
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from Demo";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<DemoModel> demos = new List<DemoModel>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    demos.Add(new DemoModel() { Id = sqlDataReader.GetInt32("Id"), Name = sqlDataReader.GetString("Name") });
                }
            }

            sqlDataReader.Close();

            return demos;
        }
    }
}
