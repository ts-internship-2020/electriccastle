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

            context.Conference.Add(new Conference
            {
                ConferenceName = conference.ConferenceName,
                OrganizerEmail = conference.OrganizerEmail,
                OrganizerName = conference.OrganizerName,
                StartDate = conference.StartDate,
                EndDate = conference.EndDate,
                DictionaryConferenceCategoryId = conference.DictionaryConferenceCategoryId,
                DictionaryConferenceTypeId = conference.DictionaryConferenceTypeId,
                Location = new Location {
                    DictionaryCityId = conference.DictionaryCityId,
                    AdressDetails = conference.AdressDetails
                },
                ConferenceXdictionarySpeaker = conference.Speakers.Select(confSpeaker => new ConferenceXdictionarySpeaker { 
                    DictionarySpeakerId = confSpeaker.DictionarySpeakerId,
                    IsMainSpeaker = confSpeaker.IsMainSpeaker,
                }).ToList()
            });

            context.SaveChanges();
        }

        public void DeleteConference(int conferenceId)
        {
            Conference conference = context.Conference.Find(conferenceId);

            Location location = context.Location.Find(conference.LocationId);

            List<ConferenceXdictionarySpeaker> conferenceXdictionarySpeaker = 
                context.ConferenceXdictionarySpeaker.Where(confspeaker => confspeaker.ConferenceId == conferenceId)
                                                    .ToList();

            context.ConferenceXdictionarySpeaker.RemoveRange(conferenceXdictionarySpeaker);

            context.SaveChanges();

            context.Conference.Remove(conference);

            context.SaveChanges();

            context.Location.Remove(location);

            context.SaveChanges();

        }

        public void EditConference(ConferenceModel conference)
        {
            Conference EFconference = context.Conference.Include(conf => conf.Location)
                                                            .ThenInclude(location => location.DictionaryCity)
                                                        .Include(conf => conf.ConferenceXdictionarySpeaker)
                                                        .Where(conf => conf.ConferenceId == conference.ConferenceId)
                                                        .FirstOrDefault();

            EFconference.ConferenceName = conference.ConferenceName;
            EFconference.OrganizerEmail = conference.OrganizerEmail;
            EFconference.OrganizerName = conference.OrganizerName;
            EFconference.Location.AdressDetails = conference.AdressDetails;
            EFconference.StartDate = conference.StartDate;
            EFconference.EndDate = conference.EndDate;
            EFconference.DictionaryConferenceCategoryId = conference.DictionaryConferenceCategoryId;
            EFconference.DictionaryConferenceTypeId = conference.DictionaryConferenceTypeId;
            EFconference.Location.DictionaryCityId = conference.DictionaryCityId;
            EFconference.ConferenceXdictionarySpeaker = conference.Speakers.Select(confSpeaker => new ConferenceXdictionarySpeaker
            {
                DictionarySpeakerId = confSpeaker.DictionarySpeakerId,
                IsMainSpeaker = confSpeaker.IsMainSpeaker,
            }).ToList();

            context.SaveChanges();
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
