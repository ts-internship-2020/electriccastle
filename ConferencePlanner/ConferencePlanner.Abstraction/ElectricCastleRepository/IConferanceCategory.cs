using ConferencePlanner.Abstraction.ElectricCastleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IConferanceCategory
    {
        public List<ConferanceCategory> GetConferencesCategory();
    }
}
