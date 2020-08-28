using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricRepository;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

        public void InsertConferenceDistrict()
        {
            throw new NotImplementedException();
        }

        public void UpdateConferenceDistrict()
        {
            throw new NotImplementedException();
        }

        public void DeleteConferenceDistrict()
        {
            throw new NotImplementedException();
        }
    }
}
