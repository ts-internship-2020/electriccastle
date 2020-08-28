using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;


namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class ConferenceTypeRepository : IConferenceTypeRepository
    {


        private readonly SqlConnection _sqlConnection;

        public ConferenceTypeRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public void deleteType( int idConferenceTypeId )
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;

            sqlCommand.Parameters.AddWithValue("@DictionaryConferenceTypeId", idConferenceTypeId);
            sqlCommand.CommandText = "DELETE from DictionaryConferenceType where DictionaryConferenceTypeId=@DictionaryConferenceTypeId";

            int rows = sqlCommand.ExecuteNonQuery();

        }

        public List<ConferenceTypeModel> getAllTypes()
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.CommandText = "SELECT DictionaryConferenceTypeId, DictionaryConferenceTypeName," +
                                     " ConferenceTypeCode FROM DictionaryConferenceType";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<ConferenceTypeModel> type = new List<ConferenceTypeModel>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    type.Add(new ConferenceTypeModel()
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

       

        public void getType(ConferenceTypeModel conferenceType)
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.Parameters.AddWithValue("@DictionaryConferenceTypeId", conferenceType.ConferenceTypeId);
            sqlCommand.Parameters.AddWithValue("@DictionaryConferenceTypeName", conferenceType.ConferenceTypeName);
            sqlCommand.Parameters.AddWithValue("@DictionaryConferenceTypeCode", conferenceType.ConferenceTypeCode);

            sqlCommand.CommandText = "UPDATE DictionaryConferenceType set DictionaryConferenceTypeName=@DictionaryConferenceTypeName," +
                                       "ConferenceTypeCode=@DictionaryConferenceTypeCode where DictionaryConferenceTypeId=@DictionaryConferenceTypeId ";

        int rows=  sqlCommand.ExecuteNonQuery();
           






        }

        public void insertType(ConferenceTypeModel conferenceType)
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;

            //sqlCommand.Parameters.AddWithValue("@DictionaryConferenceTypeId", conferenceType.ConferenceTypeId);
            sqlCommand.Parameters.AddWithValue("@DictionaryConferenceTypeName", conferenceType.ConferenceTypeName);
            sqlCommand.Parameters.AddWithValue("@DictionaryConferenceTypeCode", conferenceType.ConferenceTypeCode);

            sqlCommand.CommandText = "insert into DictionaryConferenceType(DictionaryConferenceTypeId, DictionaryConferenceTypeName, ConferenceTypeCode) values ((select max(DictionaryConferenceTypeId) from DictionaryConferenceType)+1, @DictionaryConferenceTypeName, @DictionaryConferenceTypeCode)";

            int rows = sqlCommand.ExecuteNonQuery();

        }
    }
}
