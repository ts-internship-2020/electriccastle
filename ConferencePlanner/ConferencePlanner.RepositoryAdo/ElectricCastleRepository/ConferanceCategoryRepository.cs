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
using ConferencePlanner.Abstraction.ElectricCastleModel;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
   public class ConferanceCategoryRepository: IConferanceCategory
    {

        private readonly SqlConnection _sqlConnection;

        public ConferanceCategoryRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public List<ConferanceCategory> GetConferencesCategory()
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();

            sqlCommand.CommandText = "select DictionaryConferenceCategoryName from DictionaryConferenceCategory";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<ConferanceCategory> category = new List<ConferanceCategory>();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    category.Add(new ConferanceCategory() { DictionaryConferenceCategoryName = sqlDataReader.GetString("DictionaryConferenceCategoryName") });
                }
            }

            //sqlCommand.CommandText = "update DictionaryParticipantState set DictionaryParticipantStateName=demosState.State";

            sqlDataReader.Close();

            return category;

        }

      

    }
}
