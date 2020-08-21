using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class ConferenceRepository : IConferenceRepository
    {
        public List<ConferenceModel> GetAllConferences()
        {
            throw new NotImplementedException();
        }

        public List<ConferenceModel> GetConferencesForOrganizer(string email)
        {
            throw new NotImplementedException();
        }
    }
}
