using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricRepository;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IDictionaryParticipantState
    {
        List<ParticipantStateDemo> GetDictionaryParticipantStates(string state);
    }
}
