using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Repository.Ef.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferencePlanner.Repository.Ef.Repository
{
    public class EmailRepository : IEmailParticipant
    {

        private readonly electriccastleContext _electriccastleContext;

        public EmailRepository(electriccastleContext electriccastleContext)
        {
            _electriccastleContext = electriccastleContext;

        }
        public void InsertEmailParticipantBD(int id, string email)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmail(string Email, string EmailCode)
        {

            var result = _electriccastleContext.ConferenceParticipant.FirstOrDefault(a => a.ParticipantEmail == Email);
            result.EmailCode = EmailCode;
            _electriccastleContext.SaveChanges();
        }
    }
}
