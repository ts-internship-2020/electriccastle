using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricCastleModel;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IParticipantsConferencesRepository
    {
        public List<ParticipantsConferencesModel> GetParticipantsConferences();

        public void UpdateParticipantsConferencesState(int index, string email);
    }
}
