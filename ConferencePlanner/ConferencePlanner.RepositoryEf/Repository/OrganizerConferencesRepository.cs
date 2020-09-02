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
    public class OrganizerConferencesRepository : IOrganizerConferencesRepository
    {
        private readonly electriccastleContext context;

        public OrganizerConferencesRepository(electriccastleContext electriccastleContext)
        {
            context = electriccastleContext;
        }

        public List<OrganizerConferencesModel> GetConferencesForOrganizer(string email)
        {
            List<Conference> conferences = context.Conference.Include(conf => conf.DictionaryConferenceCategory)
                                                             .Include(conf => conf.DictionaryConferenceType)
                                                             .Include(conf => conf.Location)
                                                                .ThenInclude(loc => loc.DictionaryCity)
                                                                .ThenInclude(city => city.DictionaryDistrict)
                                                                .ThenInclude(district => district.DictionaryCountry)
                                                             .Include(conf => conf.ConferenceXdictionarySpeaker)
                                                                .ThenInclude(confspeaker => confspeaker.DictionarySpeaker)
                                                             .Where(conf => conf.OrganizerEmail.ToLower().Equals(email.ToLower()))
                                                             .ToList();

            return conferences.Select(conf => new OrganizerConferencesModel
            {
                ConferenceId = conf.ConferenceId,
                ConferenceName = conf.ConferenceName,
                StartDate = conf.StartDate,
                EndDate = conf.EndDate,
                ConferenceType = conf.DictionaryConferenceType.DictionaryConferenceTypeName,
                ConferenceCategory = conf.DictionaryConferenceCategory.DictionaryConferenceCategoryName,
                Adress = conf.Location.DictionaryCity.DictionaryCityName + ", " +
                         conf.Location.DictionaryCity.DictionaryDistrict.DictionaryCountry.CountryCode,
                MainSpeaker = conf.ConferenceXdictionarySpeaker.Where(speaker => speaker.IsMainSpeaker).FirstOrDefault().DictionarySpeaker.DictionarySpeakerName
            }).ToList();
        }
    }
}
