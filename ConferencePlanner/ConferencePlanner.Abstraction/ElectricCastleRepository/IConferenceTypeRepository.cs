using ConferencePlanner.Abstraction.ElectricCastleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IConferenceTypeRepository
    {
        public List<ConferenceTypeModel> getAllTypes();
        public void getType(ConferenceTypeModel conferenceType);

        public void insertType(ConferenceTypeModel conferenceType);

        public void deleteType(int idConferenceTypeId);

        
    }
}
