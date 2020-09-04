using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricCastleModel;


namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IAddConferenceDistrictRepository
    {

        public List<AddConferenceDistrictModel> GetConferencesDistrictForCountry(int CountryId);

        public List<AddConferenceDistrictModel> GetConferencesDistrict();

        public void InsertConferenceDistrict(AddConferenceDistrictModel conferenceDistrict);

        public void UpdateConferenceDistrict(AddConferenceDistrictModel conferenceDistrict);

        public void DeleteConferenceDistrict(int districtId);

        public int GetNextId();

        public AddConferenceDistrictModel GetDistrict(int districtId);
    }
}
