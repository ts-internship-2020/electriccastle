using ConferencePlanner.Abstraction.ElectricCastleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IOrganizerConferencesRepository
    {
        public List<OrganizerConferencesModel> GetAllConferences();

        public List<OrganizerConferencesModel> GetConferencesForOrganizer(string email);
    }
}
