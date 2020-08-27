using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class ConferenceCategoryRepository : IConferenceCategoryRepository
    {
        private readonly SqlConnection _sqlConnection;

        public ConferenceCategoryRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public void deleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<ConferenceCategoryModel> getAllCategories()
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.CommandText = "SELECT DictionaryConferenceCategoryId, DictionaryConferenceCategoryName," +
                                     " ConferenceCategoryCode FROM DictionaryConferenceCategory";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<ConferenceCategoryModel> categories = new List<ConferenceCategoryModel>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    categories.Add(new ConferenceCategoryModel()
                    {
                        ConferenceCategoryId = sqlDataReader.GetInt32("DictionaryConferenceCategoryId"),
                        ConferenceCategoryName = sqlDataReader.GetString("DictionaryConferenceCategoryName"),
                        ConferenceCategoryCode = sqlDataReader.GetString("ConferenceCategoryCode")
                    });
                }
            }

            sqlDataReader.Close();

            return categories;
        }

        public ConferenceCategoryModel getCategoryForConference(int ConferenceId)
        {
            throw new NotImplementedException();
        }
    }
}
