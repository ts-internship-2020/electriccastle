﻿using System.Collections.Generic;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using System.Data;
using System.Data.SqlClient;


namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class AddConferenceCountryRepository : IAddConferenceCountryRepository
    {
        private readonly SqlConnection _sqlConnection;

        public AddConferenceCountryRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        private string name;
        private string cod;

        public List<AddConferenceCountryModel> GetConferencesCountry()
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();

            sqlCommand.CommandText = "select DictionaryCountryId, CountryCode, DictionaryCountryName from DictionaryCountry";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<AddConferenceCountryModel> country = new List<AddConferenceCountryModel>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    country.Add(new AddConferenceCountryModel() 
                    { 
                        DictionaryCountryId = sqlDataReader.GetInt32("DictionaryCountryId"),
                        CountryCode = sqlDataReader.GetString("CountryCode"),
                        DictionaryCountryName = sqlDataReader.GetString("DictionaryCountryName")
                    });
                }
            }

            sqlDataReader.Close();

            return country;
        }

        public void InsertConferenceCountry(string cod, string name)
        {

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Cod", cod);
            parameters[1] = new SqlParameter("@Name", name);
           

            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            //if ($"select DictionaryCountryName from DictionaryCountry".Contains(name))
            //    message = "This country is already into database";

                sqlCommand.CommandText = $"insert into DictionaryCountry values((select MAX(DictionaryCountryId) from DictionaryCountry)+1,@Cod,@Name)";
                sqlCommand.Parameters.Add(parameters[0]);
                sqlCommand.Parameters.Add(parameters[1]);

            sqlCommand.ExecuteNonQuery();

        }
      
        public void UpdateConferenceCountry(string cod, string name, int index)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@Cod", cod);
            parameters[1] = new SqlParameter("@Name", name);
            parameters[2] = new SqlParameter("@index", index);

            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            

            sqlCommand.CommandText = $"update DictionaryCountry set CountryCode=@Cod ,DictionaryCountryName=@Name where DictionaryCountryId= @index";

            sqlCommand.Parameters.Add(parameters[0]);
            sqlCommand.Parameters.Add(parameters[1]);
            sqlCommand.Parameters.Add(parameters[2]);


            sqlCommand.ExecuteNonQuery();
        }

        public void DeleteConferenceCoutry(int index)
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@index", index);
            sqlCommand.Parameters.Add(parameters[0]);
            sqlCommand.CommandText = $"delete from DictionaryCountry where DictionaryCountryId =@index";
           
            sqlCommand.ExecuteNonQuery();
        }


      
    }
}
