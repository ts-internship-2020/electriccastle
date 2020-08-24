using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;

namespace ConferencePlanner.Repository.Ado.ElectricCastleRepository
{
    public class OrganizerConferencesRepository : IOrganizerConferencesRepository
    {
        public List<OrganizerConferencesModel> GetAllConferences()
        {
            throw new NotImplementedException();
        }

        public List<OrganizerConferencesModel> GetConferencesForOrganizer(string email)
        {
            throw new NotImplementedException();
        }
    }
}
