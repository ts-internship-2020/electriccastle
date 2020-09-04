using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Repository.Ef.Entities;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConferencePlanner.Repository.Ef.Repository
{
    public class DictionaryCityRepositoryEF : IAddConferenceCityRepository
    {
        private readonly electriccastleContext _electriccastleContext;
        public DictionaryCityRepositoryEF(electriccastleContext electriccastleContext)
        {
            _electriccastleContext = electriccastleContext;

        }

        public void deleteCity(int cityId)
        {
            var deletecity = _electriccastleContext.DictionaryCity.FirstOrDefault((x => x.DictionaryCityId == cityId));

            _electriccastleContext.DictionaryCity.Remove(deletecity);
            _electriccastleContext.SaveChanges();
           
        }

        public List<AddConferenceCityModel> GetConferencesCity()
        {
            List<DictionaryCity> conferences = _electriccastleContext.DictionaryCity.Include(x => x.DictionaryDistrict).ToList();

            List<AddConferenceCityModel> demoModels = conferences.Select(a => new AddConferenceCityModel() { DictionaryCityId = a.DictionaryCityId, CityCode = a.CityCode, DictionaryCityName = a.DictionaryCityName, DictionaryDistrictId = (int)a.DictionaryDistrictId }).ToList();

            return demoModels;
            
        }

        public List<AddConferenceCityModel> GetConferencesCityForDistrict(int DistrictId)
        {
            throw new NotImplementedException();
        }

        public void insertCity(int id, int cityDistrictId, string cityCode, string cityName)
        {
            var idx = _electriccastleContext.DictionaryCity.Max(x => x.DictionaryCityId) + 1;
            var cities = new DictionaryCity { DictionaryCityId = idx, CityCode = cityCode, DictionaryCityName = cityName, DictionaryDistrictId = cityDistrictId };

            _electriccastleContext.DictionaryCity.Add(cities);
            _electriccastleContext.SaveChanges();
            
        }

        public void updateCity(int cityId, string cityCode, string cityName, int cityDistrictId)
        {
            DictionaryCity updatecity = _electriccastleContext.DictionaryCity.Where(x => x.DictionaryCityId == cityId).FirstOrDefault();
            updatecity.CityCode = cityCode;
            updatecity.DictionaryCityName = cityName;
            updatecity.DictionaryDistrictId = cityDistrictId;

            _electriccastleContext.DictionaryCity.Update(updatecity);
            _electriccastleContext.SaveChanges();
            
        }
    }
}
