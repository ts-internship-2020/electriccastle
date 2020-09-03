using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IEmailParticipant
    {
        public void InsertEmailParticipantBD(int id,string email);
        public void UpdateEmail(string Email, string EmailCode);
    }
}
