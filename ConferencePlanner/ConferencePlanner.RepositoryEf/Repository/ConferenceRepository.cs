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
    public class ConferenceRepository : IConferenceRepository
    {
        private readonly electriccastleContext context;

        public ConferenceRepository(electriccastleContext electriccastleContext)
        {
            context = electriccastleContext;
        }

        public void AddConference(ConferenceModel conference)
        {
            throw new NotImplementedException();
        }

        public void DeleteConference(int conferenceId)
        {
            throw new NotImplementedException();
        }

        public void EditConference(ConferenceModel conference)
        {
            throw new NotImplementedException();
        }

        public ConferenceModel GetConference(int conferenceId)
        {
            Conference conference = context.Conference.Include(conf => conf.Location)
                                                          .ThenInclude(location => location.DictionaryCity)
                                                          .ThenInclude(city => city.DictionaryDistrict)
                                                          .ThenInclude(district => district.DictionaryCountry)
                                                      .Include(conf => conf.ConferenceXdictionarySpeaker)
                                                      .Where(conf => conf.ConferenceId == conferenceId)
                                                      .FirstOrDefault();

            return new ConferenceModel
            {
                ConferenceId = conference.ConferenceId,
                ConferenceName = conference.ConferenceName,
                OrganizerEmail = conference.OrganizerEmail,
                OrganizerName = conference.OrganizerName,
                StartDate = conference.StartDate,
                EndDate = conference.EndDate,
                DictionaryConferenceCategoryId = (int)conference.DictionaryConferenceCategoryId,
                DictionaryConferenceTypeId = (int)conference.DictionaryConferenceTypeId,
                LocationId = conference.LocationId,
                AdressDetails = conference.Location.AdressDetails,
                Speakers = conference.ConferenceXdictionarySpeaker.Select(speaker => new SpeakerListModel
                {
                    DictionarySpeakerId = speaker.DictionarySpeakerId,
                    IsMainSpeaker = speaker.IsMainSpeaker
                }).ToList(),
                DictionaryCityId = conference.Location.DictionaryCity.DictionaryCityId,
                DictionaryDistrictId = conference.Location.DictionaryCity.DictionaryDistrict.DictionaryDistrictId,
                DictionaryCountryId = conference.Location.DictionaryCity.DictionaryDistrict.DictionaryCountry.DictionaryCountryId
            };
        }
    }
}
