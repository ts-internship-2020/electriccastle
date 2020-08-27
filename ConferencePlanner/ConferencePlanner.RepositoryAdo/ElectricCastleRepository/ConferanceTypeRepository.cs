using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;


namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class ConferanceTypeRepository : IConferanceTypeRepository
    {


        private readonly SqlConnection _sqlConnection;

        public ConferanceTypeRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public List<ConferanceTypeModel> getAllTypes()
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.CommandText = "SELECT DictionaryConferenceTypeId, DictionaryConferenceTypeName," +
                                     " ConferenceTypeCode FROM DictionaryConferenceType";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<ConferanceTypeModel> type = new List<ConferanceTypeModel>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    type.Add(new ConferanceTypeModel()
                    {
                        ConferenceTypeId = sqlDataReader.GetInt32("DictionaryConferenceTypeId"),
                        ConferenceTypeName = sqlDataReader.GetString("DictionaryConferenceTypeName"),
                        ConferenceTypeCode = sqlDataReader.GetString("ConferenceTypeCode")
                    });
                }
            }

            sqlDataReader.Close();

            return type;

        }
    }
}
