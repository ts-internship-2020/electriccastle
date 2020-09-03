using System;
using System.Collections.Generic;
using System.Text;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using Microsoft.EntityFrameworkCore;
using ConferencePlanner.Abstraction.Model;
using ConferencePlanner.Abstraction.Repository;
using ConferencePlanner.Repository.Ef.Entities;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace ConferencePlanner.Repository.Ef.Repository
{
   public  class GetCountryRepositoryEntFr:IAddConferenceCountryRepository
    {
        private readonly electriccastleContext _electriccastleContext;

        public GetCountryRepositoryEntFr(electriccastleContext electriccastleContext)
        {
            _electriccastleContext = electriccastleContext;

        }

        public void DeleteConferenceCoutry(int index)
        {
            var country = _electriccastleContext.DictionaryCountry.FirstOrDefault(x => x.DictionaryCountryId == index);
            _electriccastleContext.DictionaryCountry.Remove(country);
            _electriccastleContext.SaveChanges();
        
        }

        public List<AddConferenceCountryModel> GetConferencesCountry()
        {
            List<DictionaryCountry> country = _electriccastleContext.DictionaryCountry.ToList();

            List<AddConferenceCountryModel> demoModels = country.Select(a => new AddConferenceCountryModel() { DictionaryCountryId = a.DictionaryCountryId, DictionaryCountryName = a.DictionaryCountryName, CountryCode= a.CountryCode }).ToList();

            return demoModels;
        }

        public void InsertConferenceCountry(string cod, string name)
        {

            var country = _electriccastleContext.DictionaryCountry.ToList();


            var countrys = new DictionaryCountry { DictionaryCountryId= _electriccastleContext.DictionaryCountry.Max(x=>x.DictionaryCountryId)+1, CountryCode = cod, DictionaryCountryName =name };
            _electriccastleContext.DictionaryCountry.Add(countrys);
            _electriccastleContext.SaveChanges();

        }

        public void UpdateConferenceCountry(string cod, string name, int index)
        {
            var country = _electriccastleContext.DictionaryCountry.Where(x=> x.DictionaryCountryId == index).FirstOrDefault();
            country.CountryCode = cod;
            country.DictionaryCountryName = name;
            //_electriccastleContext.DictionaryCountry.Add(country);
            _electriccastleContext.SaveChanges();
        }
    }
}
