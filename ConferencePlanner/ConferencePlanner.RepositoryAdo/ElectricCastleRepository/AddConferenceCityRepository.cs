using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System.Data;
using System.Data.SqlClient;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class AddConferenceCityRepository : IAddConferenceCityRepository
    {
        private readonly SqlConnection _sqlConnection;

        public AddConferenceCityRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

       

        public List<AddConferenceCityModel> GetConferencesCity()
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();

            sqlCommand.CommandText = "select DictionaryCityId, CityCode, DictionaryCityName , dd.DictionaryDistrictId  from DictionaryCity dcty join DictionaryDistrict dd on dd.DictionaryDistrictId= dcty.DictionaryDistrictId";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<AddConferenceCityModel> city = new List<AddConferenceCityModel>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    city.Add(new AddConferenceCityModel()
                    {
                        DictionaryCityId = sqlDataReader.GetInt32("DictionaryCityId"),
                        CityCode = sqlDataReader.GetString("CityCode"),
                        DictionaryCityName = sqlDataReader.GetString("DictionaryCityName"),
                        DictionaryDistrictId = sqlDataReader.GetInt32("DictionaryDistrictId")
                    });
                }
            }

            sqlDataReader.Close();

            return city;
        }

        public void InsertConferenceCity(int id, string name, string cod)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@Id", id);
            parameters[1] = new SqlParameter("@Name", name);
            parameters[2] = new SqlParameter("@Cod", cod);

            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"insert into ConferenceParticipant values(@Id,@Email,1)";
            sqlCommand.Parameters.Add(parameters[0]);
            sqlCommand.Parameters.Add(parameters[1]);
        }

        public void updateCity(int cityId, string cityCode, string cityName , int cityDistrictId )
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@Id", cityId);
            parameters[1] = new SqlParameter("@Code", cityCode);
            parameters[2] = new SqlParameter("@Name", cityName);
            parameters[3] = new SqlParameter("@DistrictId", cityDistrictId);

            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"update DictionaryCity set CityCode = @Code, DictionaryCityName = @Name, DictionaryDistrictId = @DistrictId where DictionaryCityId = @Id;";
            sqlCommand.Parameters.Add(parameters[0]);
            sqlCommand.Parameters.Add(parameters[1]);
            sqlCommand.Parameters.Add(parameters[2]);
            sqlCommand.Parameters.Add(parameters[3]);


            int nr = sqlCommand.ExecuteNonQuery();
        }

        public void deleteCity(int cityId)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", cityId);
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"delete from DictionaryCity where DictionaryCityId = @Id;";
            sqlCommand.Parameters.Add(parameters[0]);
            int nr = sqlCommand.ExecuteNonQuery();
        }

        public void insertCity(int cityId, int cityDistrictId, string cityCode, string cityName)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@Id", cityId);
            parameters[1] = new SqlParameter("@Code", cityCode);
            parameters[2] = new SqlParameter("@Name", cityName);
            parameters[3] = new SqlParameter("@DistrictId", cityDistrictId);

            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"insert into DictionaryCity values(@Id,@Code,@Name,@DistrictId)";
            sqlCommand.Parameters.Add(parameters[0]);
            sqlCommand.Parameters.Add(parameters[1]);
            sqlCommand.Parameters.Add(parameters[2]);
            sqlCommand.Parameters.Add(parameters[3]);


            int nr = sqlCommand.ExecuteNonQuery();

        }
    }
}
