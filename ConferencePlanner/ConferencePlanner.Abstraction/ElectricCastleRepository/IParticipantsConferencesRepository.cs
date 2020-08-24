using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ParticipantsModel;

namespace ConferencePlanner.Abstraction.ParticipantRepository
{
    public interface IParticipantsConferencesRepository
    {

        void test();
        public List<ParticipantsConferencesModel> GetParticipantsConferences();
    }
}
