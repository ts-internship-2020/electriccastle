using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricCastleModel;


namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IAddConferenceCityRepository
    {
        public List<AddConferenceCityModel> GetConferencesCity();

        public void UpdateConferenceCity();

        public void InsertConferenceCity();


        public void DeleteConferenceCitry();
    }
}
