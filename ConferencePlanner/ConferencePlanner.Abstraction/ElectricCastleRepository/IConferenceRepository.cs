using ConferencePlanner.Abstraction.ElectricCastleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IConferenceRepository
    {
        public void AddConference(ConferenceModel conference);

        public void EditConference(ConferenceModel conference);

        public void DeleteConference(int conferenceId);

        public ConferenceModel GetConference(int conferenceId);
    }
}
