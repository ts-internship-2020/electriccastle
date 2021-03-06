﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using ConferencePlanner.Abstraction.ElectricCastleRepository;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class InsertEmailParticipant : IEmailParticipant
    {
        private readonly SqlConnection _sqlConnection;

        public InsertEmailParticipant(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public void InsertEmailParticipantBD(int id,string email)
        {

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Id", id);
            parameters[1] = new SqlParameter("@EmailP", email);

            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            //sqlCommand.CommandText = $"insert into ConferenceParticipant values(@Id+1,@Email,1)";
            sqlCommand.CommandText = $"execute InsertParticipantEmailConference @Id, @EmailP";
            sqlCommand.Parameters.Add(parameters[0]);
            sqlCommand.Parameters.Add(parameters[1]);

            sqlCommand.ExecuteNonQuery();
        }

        public void UpdateEmail(string Email, string EmailCode)
        {
            SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.Parameters.AddWithValue("@EmailCode", EmailCode);
            sqlCommand.Parameters.AddWithValue("@ParticipantEmail", Email);

            sqlCommand.CommandText = "UPDATE ConferenceParticipant set EmailCode=@EmailCode where ParticipantEmail=@ParticipantEmail";


            int rows = sqlCommand.ExecuteNonQuery();
        }
    }
}
