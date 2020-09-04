using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Repository.Ef.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferencePlanner.Repository.Ef.Repository
{
    public class GetDistrictRepositoryEntFrcs : IAddConferenceDistrictRepository
    {
        private readonly electriccastleContext _electriccastleContext;

        public GetDistrictRepositoryEntFrcs(electriccastleContext electriccastleContext)
        {
            _electriccastleContext = electriccastleContext;

        }

        public void DeleteConferenceDistrict(int districtId)
        {
            var district = _electriccastleContext.DictionaryDistrict.FirstOrDefault(x => x.DictionaryDistrictId == districtId);
            _electriccastleContext.DictionaryDistrict.Remove(district);
            _electriccastleContext.SaveChanges();

        }

        public List<AddConferenceDistrictModel> GetConferencesDistrict()
        {
            //List<DictionaryDistrict> district = _electriccastleContext.DictionaryDistrict.Include(x => x.DictionaryCountry).ToList();
            List<DictionaryDistrict> district = _electriccastleContext.DictionaryDistrict.ToList();
            List<AddConferenceDistrictModel> demoModels = district.Select(a => new AddConferenceDistrictModel() { DictionaryDistrictId = a.DictionaryDistrictId, DictionaryDistrictName = a.DictionaryDistrictName, DistrictCode = a.DistrictCode, DictionaryCountryId = (int)a.DictionaryCountryId }).ToList();

            return demoModels;
        }

        public List<AddConferenceDistrictModel> GetConferencesDistrictForCountry(int CountryId)
        {
            throw new NotImplementedException();
        }

        public AddConferenceDistrictModel GetDistrict(int districtId)
        {
            throw new NotImplementedException();
        }

        public int GetNextId()
        {
            throw new NotImplementedException();
        }

        public void InsertConferenceDistrict(AddConferenceDistrictModel conferenceDistrict)
        {

            var district = _electriccastleContext.DictionaryDistrict.ToList();


            var districts = new DictionaryDistrict { DictionaryDistrictId = _electriccastleContext.DictionaryDistrict.Max(x => x.DictionaryDistrictId) + 1, DistrictCode = conferenceDistrict.DistrictCode, DictionaryDistrictName = conferenceDistrict.DictionaryDistrictName, DictionaryCountryId = conferenceDistrict.DictionaryCountryId };
            _electriccastleContext.DictionaryDistrict.Add(districts);
            _electriccastleContext.SaveChanges();
        }

        public void UpdateConferenceDistrict(AddConferenceDistrictModel conferenceDistrict)
        {
            var district = _electriccastleContext.DictionaryDistrict.Where(x => x.DictionaryDistrictId == conferenceDistrict.DictionaryDistrictId).FirstOrDefault();
            district.DictionaryDistrictName = conferenceDistrict.DictionaryDistrictName;
            district.DistrictCode = conferenceDistrict.DistrictCode;
            _electriccastleContext.SaveChanges();
        }
    }
}
