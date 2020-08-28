using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricCastleModel;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface ISpeakerRepository
    {
        public List<SpeakerModel> GetSpeaker();

        public void deleteSpeaker(int speakerId);

        public void editSpeaker(int speakerId, string speakerCode, string speakerName, decimal SpeakerRating, string speakerNationality, string speakerPicture);

        public void addSpeaker(int speakerId, string speakerCode, string speakerName, decimal SpeakerRating, string speakerNationality, string speakerPicture);
    }
}
