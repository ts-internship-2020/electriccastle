using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricCastleModel;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IAddConferenceCountryRepository
    {
        public List<AddConferenceCountryModel> GetConferencesCountry();

        public void InsertConferenceCountry(string cod, string name);

        public void UpdateConferenceCountry(string cod, string name, int index);

        public void DeleteConferenceCoutry(int index);
    }
}
