using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricCastleModel;


namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IAddConferenceCityRepository
    {

        public List<AddConferenceCityModel> GetConferencesCityForDistrict(int DistrictId);

        public List<AddConferenceCityModel> GetConferencesCity();

        public void updateCity(int cityId, string cityCode, string cityName, int cityDistrictId);

        public void insertCity(int cityId, int cityDistrictId, string cityCode, string cityName);


        public void deleteCity( int cityId);
    }
}
