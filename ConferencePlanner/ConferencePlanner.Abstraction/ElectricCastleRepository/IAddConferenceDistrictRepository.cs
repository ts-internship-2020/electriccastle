using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricCastleModel;


namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IAddConferenceDistrictRepository
    {
        public List<AddConferenceDistrictModel> GetConferencesDistrict();

        public void InsertConferenceDistrict();

        public void UpdateConferenceDistrict();

        public void DeleteConferenceDistrict();
    }
}
