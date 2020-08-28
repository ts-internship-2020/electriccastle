using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Diagnostics;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class ConferenceCategoryRepository : IConferenceCategoryRepository
    {
        private readonly SqlConnection _sqlConnection;

        public ConferenceCategoryRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public void addCategory(ConferenceCategoryModel conferenceCategory)
        {
            try { 
                SqlCommand sqlCommand = _sqlConnection.CreateCommand();
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.Parameters.AddWithValue("@CategoryId", conferenceCategory.ConferenceCategoryId);
                sqlCommand.Parameters.AddWithValue("@CategoryName", conferenceCategory.ConferenceCategoryName);
                sqlCommand.Parameters.AddWithValue("@CategoryCode", conferenceCategory.ConferenceCategoryCode);
                sqlCommand.CommandText = " INSERT INTO DictionaryConferenceCategory (DictionaryConferenceCategoryId," +
                                         " DictionaryConferenceCategoryName, ConferenceCategoryCode)" +
                                         " VALUES(@CategoryId, @CategoryName, @CategoryCode)";

                int rowsAdded = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public void deleteCategory(int categoryId)
        {
            try { 
                SqlCommand sqlCommand = _sqlConnection.CreateCommand();
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.Parameters.AddWithValue("@CategoryId", categoryId);
                sqlCommand.CommandText = " DELETE FROM DictionaryConferenceCategory" +
                                         " WHERE DictionaryConferenceCategoryId = @CategoryId";

                int rowsDeleted = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public void editCategory(ConferenceCategoryModel conferenceCategory)
        {
            try
            {
                SqlCommand sqlCommand = _sqlConnection.CreateCommand();
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.Parameters.AddWithValue("@CategoryId", conferenceCategory.ConferenceCategoryId);
                sqlCommand.Parameters.AddWithValue("@CategoryName", conferenceCategory.ConferenceCategoryName);
                sqlCommand.Parameters.AddWithValue("@CategoryCode", conferenceCategory.ConferenceCategoryCode);
                sqlCommand.CommandText = " UPDATE DictionaryConferenceCategory" +
                                         " SET DictionaryConferenceCategoryName = @CategoryName," +
                                             " ConferenceCategoryCode = @CategoryCode" +
                                         " WHERE DictionaryConferenceCategoryId = @CategoryId";

                int rowsEdited = sqlCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
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

        public ConferenceCategoryModel getCategory(int categoryId)
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.Parameters.AddWithValue("@CategoryId", categoryId);
            sqlCommand.CommandText = "SELECT DictionaryConferenceCategoryId, DictionaryConferenceCategoryName, ConferenceCategoryCode" +
                                     " FROM DictionaryConferenceCategory" +
                                     " WHERE DictionaryConferenceCategoryId = @CategoryId";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            ConferenceCategoryModel category = null;

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    category = new ConferenceCategoryModel
                    {
                        ConferenceCategoryId = sqlDataReader.GetInt32("DictionaryConferenceCategoryId"),
                        ConferenceCategoryName = sqlDataReader.GetString("DictionaryConferenceCategoryName"),
                        ConferenceCategoryCode = sqlDataReader.GetString("ConferenceCategoryCode")
                    };
                }
            }
            sqlDataReader.Close();

            return category;
        }

        public ConferenceCategoryModel getCategoryForConference(int ConferenceId)
        {
            throw new NotImplementedException();
        }

        public int getNextId()
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.CommandText = "SELECT MAX(DictionaryConferenceCategoryId) AS maxId FROM DictionaryConferenceCategory";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            int nextId = 0;

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    nextId = sqlDataReader.GetInt32("maxId") + 1;
                }
            }
            sqlDataReader.Close();

            return nextId;
        }
    }
}
