using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricCastleModel;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface ISpeakerRepository
    {
        public List<SpeakerModel> GetSpeaker();
    }
}
