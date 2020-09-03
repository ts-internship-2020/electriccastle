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
    public class ParticipantsConferenceRepositoryEf : IParticipantsConferencesRepository
    {
        private readonly electriccastleContext _electriccastleContext;
        public ParticipantsConferenceRepositoryEf(electriccastleContext electriccastleContext)
        {
            _electriccastleContext = electriccastleContext;

        }
        public List<ParticipantsConferencesModel> GetParticipantsConferences()
        {
            List<Conference> conferences = _electriccastleContext.Conference.Include(dct => dct.DictionaryConferenceType).Include(dcc => dcc.DictionaryConferenceCategory).
                                                                            Include(l => l.Location).ThenInclude(c => c.DictionaryCity).ThenInclude(dd => dd.DictionaryDistrict).ThenInclude(dc => dc.DictionaryCountry).
                                                                            Include(l => l.ConferenceParticipant).ThenInclude(ps => ps.DictionaryParticipantState).
                                                                            Include(cds => cds.ConferenceXdictionarySpeaker).ThenInclude(ds =>ds.DictionarySpeaker).
                                                                            Include(cds => cds.ConferenceParticipant).ThenInclude(ds => ds.DictionaryParticipantState)
                                                                            .ToList();
            List<ParticipantsConferencesModel> participants = conferences.Select(pc => new ParticipantsConferencesModel() 
            {   Name = pc.ConferenceName, 
                StartDate = pc.StartDate, 
                EndDate = pc.EndDate, 
                ConferenceType = pc.DictionaryConferenceType.DictionaryConferenceTypeName, 
                ConferenceCategory = pc.DictionaryConferenceCategory.DictionaryConferenceCategoryName, 
                Address = pc.Location.DictionaryCity.DictionaryCityName + ',' + pc.Location.DictionaryCity.DictionaryDistrict.DictionaryCountry.CountryCode,
                Speaker = pc.ConferenceXdictionarySpeaker.Where(dic => dic.IsMainSpeaker).FirstOrDefault().DictionarySpeaker.DictionarySpeakerName,
                Id = pc.LocationId,
               StateName = "withdraw",
               //pc.ConferenceParticipant.Where(dic => dic.DictionaryParticipantStateId ==2).FirstOrDefault().DictionaryParticipantState.DictionaryParticipantStateName
            }).ToList();

            return participants;
            throw new NotImplementedException();
        }

        public void UpdateParticipantsConferencesState(int index, string email)
        {
            var ent = _electriccastleContext.ConferenceParticipant.FirstOrDefault((x => x.ParticipantEmail == email));
            if (index == 7)
            {
                ent.DictionaryParticipantStateId = 2;
                _electriccastleContext.ConferenceParticipant.Update(ent);
            }

            if (index == 8)
            {
                ent.DictionaryParticipantStateId = 1;
                _electriccastleContext.ConferenceParticipant.Update(ent);
            }

            if (index == 9)
            {
                ent.DictionaryParticipantStateId = 3;
                _electriccastleContext.ConferenceParticipant.Update(ent);
            }

            _electriccastleContext.SaveChanges();
        }
    }
}
