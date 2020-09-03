using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Repository.Ef.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferencePlanner.Repository.Ef.Repository
{
    public class TypeRepository : IConferenceTypeRepository
    {
        private readonly electriccastleContext _electriccastleContext;

        public TypeRepository(electriccastleContext electriccastleContext)
        {
            _electriccastleContext = electriccastleContext;

        }
        public void deleteType(int idConferenceTypeId)
        {
            var conferenceType = _electriccastleContext.DictionaryConferenceType.FirstOrDefault(x => x.DictionaryConferenceTypeId == idConferenceTypeId);
            _electriccastleContext.DictionaryConferenceType.Remove(conferenceType);
            _electriccastleContext.SaveChanges();


        }
        
        public List<ConferenceTypeModel> getAllTypes()
        {
            List<DictionaryConferenceType> type = _electriccastleContext.DictionaryConferenceType.ToList();

            List <ConferenceTypeModel> alltypes = type.Select(a => new ConferenceTypeModel() { ConferenceTypeId = a.DictionaryConferenceTypeId, ConferenceTypeName = a.DictionaryConferenceTypeName, ConferenceTypeCode=a.ConferenceTypeCode }).ToList();


            return alltypes;
        }

        public void getType(ConferenceTypeModel conferenceType)
        {
           

            var result = _electriccastleContext.DictionaryConferenceType.FirstOrDefault(a => a.DictionaryConferenceTypeId==conferenceType.ConferenceTypeId);
            result.ConferenceTypeCode = conferenceType.ConferenceTypeCode;
            result.DictionaryConferenceTypeName = conferenceType.ConferenceTypeName;
   
            _electriccastleContext.SaveChanges();


           
        }

        public void insertType(ConferenceTypeModel conferenceType)
        {

            var result = _electriccastleContext.DictionaryConferenceType.ToList();
            var conferenceTypeModel = new DictionaryConferenceType { DictionaryConferenceTypeId = _electriccastleContext.DictionaryConferenceType.Max(x => x.DictionaryConferenceTypeId) + 1, DictionaryConferenceTypeName = conferenceType.ConferenceTypeName, ConferenceTypeCode = conferenceType.ConferenceTypeCode };
            _electriccastleContext.DictionaryConferenceType.Add(conferenceTypeModel);
            _electriccastleContext.SaveChanges();

        }
    }
}
