using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Repository.Ef.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferencePlanner.Repository.Ef.Repository
{
    public class SpeakerDetailRepository : ISpeakerDetailRepository
    {
        private readonly electriccastleContext context;

        public SpeakerDetailRepository(electriccastleContext electriccastleContext)
        {
            context = electriccastleContext;
        }

        public List<SpeakerDetailModel> GetSpeakerDetail()
        {
            List<DictionarySpeaker> speakers = context.DictionarySpeaker.ToList();

            return speakers.Select(speaker => new SpeakerDetailModel
            {
                Id = speaker.DictionarySpeakerId,
                Name = speaker.DictionarySpeakerName,
                Rating = (decimal)speaker.Rating,
                Nationality = speaker.Nationality,
                Picture = speaker.Picture
            }).ToList();
        }
    }
}
