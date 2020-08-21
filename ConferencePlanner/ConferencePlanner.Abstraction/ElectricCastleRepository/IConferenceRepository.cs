using ConferencePlanner.Abstraction.ElectricCastleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IConferenceRepository
    {
        public List<ConferenceModel> GetAllConferences();

        public List<ConferenceModel> GetConferencesForOrganizer(string email);
    }
}
