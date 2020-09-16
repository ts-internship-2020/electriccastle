using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricRepository;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IDictionaryParticipantState
    {
       public List<ParticipantStateDemo> GetDictionaryParticipantStates(string email);

    }
}
