using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricRepository;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class AddConferenceDistrictRepository : IAddConferenceDistrictRepository
    {
        private readonly SqlConnection _sqlConnection;

        public AddConferenceDistrictRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

       

        public List<AddConferenceDistrictModel> GetConferencesDistrict()
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();

            sqlCommand.CommandText = "select DictionaryDistrictId ,DistrictCode ,DictionaryDistrictName, dc.DictionaryCountryId from DictionaryDistrict dd join DictionaryCountry dc on dd.DictionaryCountryId= dc.DictionaryCountryId";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<AddConferenceDistrictModel> district = new List<AddConferenceDistrictModel>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    district.Add(new AddConferenceDistrictModel()
                    {
                        DictionaryDistrictId = sqlDataReader.GetInt32("DictionaryDistrictId"),
                        DistrictCode = sqlDataReader.GetString("DistrictCode"),
                        DictionaryDistrictName = sqlDataReader.GetString("DictionaryDistrictName"),
                        DictionaryCountryId = sqlDataReader.GetInt32("DictionaryCountryId")
                    });
                }
            }

            sqlDataReader.Close();

            return district;
        }

        public void InsertConferenceDistrict(AddConferenceDistrictModel conferenceDistrict)
        {
            try
            {
                SqlCommand sqlCommand = _sqlConnection.CreateCommand();
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.Parameters.AddWithValue("@DistrictId", conferenceDistrict.DictionaryDistrictId);
                sqlCommand.Parameters.AddWithValue("@DistrictName", conferenceDistrict.DictionaryDistrictName);
                sqlCommand.Parameters.AddWithValue("@DistrictCode", conferenceDistrict.DistrictCode);
                sqlCommand.Parameters.AddWithValue("@CountryId", conferenceDistrict.DictionaryCountryId);
                sqlCommand.CommandText = " INSERT INTO DictionaryDistrict(DictionaryDistrictId," +
                                         " DictionaryDistrictName, DistrictCode, DictionaryCountryId)" +
                                         " VALUES(@DistrictId, @DistrictName, @DistrictCode, @CountryId)";

                int rowsAdded = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public void UpdateConferenceDistrict(AddConferenceDistrictModel conferenceDistrict)
        {
            try
            {
                SqlCommand sqlCommand = _sqlConnection.CreateCommand();
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.Parameters.AddWithValue("@DistrictId", conferenceDistrict.DictionaryDistrictId);
                sqlCommand.Parameters.AddWithValue("@DistrictName", conferenceDistrict.DictionaryDistrictName);
                sqlCommand.Parameters.AddWithValue("@DistrictCode", conferenceDistrict.DistrictCode);
                sqlCommand.Parameters.AddWithValue("@CountryId", conferenceDistrict.DictionaryCountryId);
                sqlCommand.CommandText = " UPDATE DictionaryDistrict " +
                                         " SET DictionaryDistrictName = @DistrictName," +
                                             " DistrictCode = @DistrictCode," +
                                             " DictionaryCountryId = @CountryId" +
                                         " WHERE DictionaryDistrictId = @DistrictId";

                int rowsEdited = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public void DeleteConferenceDistrict(int districtId)
        {
            try
            {
                SqlCommand sqlCommand = _sqlConnection.CreateCommand();
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.Parameters.AddWithValue("@DistrictId", districtId);
                sqlCommand.CommandText = " DELETE FROM DictionaryDistrict" +
                                         " WHERE DictionaryDistrictId = @DistrictId";

                int rowsDeleted = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public int GetNextId()
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.CommandText = "SELECT MAX(DictionaryDistrictId) AS maxId FROM DictionaryDistrict";

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

        public AddConferenceDistrictModel GetDistrict(int districtId)
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.Parameters.AddWithValue("@DistrictId", districtId);
            sqlCommand.CommandText = " SELECT DictionaryDistrictId, DictionaryDistrictName, DistrictCode, DictionaryCountryId" +
                                     " FROM DictionaryDistrict" +
                                     " WHERE DictionaryDistrictId = @DistrictId";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            AddConferenceDistrictModel district = null;

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    district = new AddConferenceDistrictModel
                    {
                        DictionaryDistrictId = sqlDataReader.GetInt32("DictionaryDistrictId"),
                        DictionaryDistrictName = sqlDataReader.GetString("DictionaryDistrictName"),
                        DistrictCode = sqlDataReader.GetString("DistrictCode"),
                        DictionaryCountryId = sqlDataReader.GetInt32("DictionaryCountryId")
                    };
                }
            }
            sqlDataReader.Close();

            return district;
        }
    }
}
