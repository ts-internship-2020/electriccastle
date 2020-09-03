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
    public class SpeakerRepositoryEf : ISpeakerRepository
    {

        private readonly electriccastleContext _electriccastleContext;
        public SpeakerRepositoryEf(electriccastleContext electriccastleContext)
        {
            _electriccastleContext = electriccastleContext;

        }
        public void addSpeaker(int speakerId, string speakerCode, string speakerName, decimal SpeakerRating, string speakerNationality, string speakerPicture)
        {
            var idx = _electriccastleContext.DictionarySpeaker.Max(x => x.DictionarySpeakerId) + 1;
            var speakers = new DictionarySpeaker { DictionarySpeakerId = idx, SpeakerCode = speakerCode, DictionarySpeakerName = speakerName, Rating = SpeakerRating, Nationality = speakerNationality, Picture = speakerPicture };

            _electriccastleContext.DictionarySpeaker.Add(speakers);
            _electriccastleContext.SaveChanges();
        }

        public void deleteSpeaker(int speakerId)
        {
            var deletespeaker = _electriccastleContext.DictionarySpeaker.FirstOrDefault((x => x.DictionarySpeakerId == speakerId));

            _electriccastleContext.DictionarySpeaker.Remove(deletespeaker);
            _electriccastleContext.SaveChanges();
        }

        public void editSpeaker(int speakerId, string speakerCode, string speakerName, decimal SpeakerRating, string speakerNationality, string speakerPicture)
        {
            DictionarySpeaker updatespeaker = _electriccastleContext.DictionarySpeaker.Where(x => x.DictionarySpeakerId == speakerId).FirstOrDefault();
            updatespeaker.SpeakerCode = speakerCode;
            updatespeaker.DictionarySpeakerName = speakerName;
            updatespeaker.Rating = SpeakerRating;
            updatespeaker.Nationality = speakerNationality;
            updatespeaker.Picture = speakerPicture;

            _electriccastleContext.DictionarySpeaker.Update(updatespeaker);
            _electriccastleContext.SaveChanges();
        }

        public List<SpeakerModel> GetSpeaker()
        {
            List<DictionarySpeaker> speakers = _electriccastleContext.DictionarySpeaker.ToList();
            List<SpeakerModel> speakModel = speakers.Select(a => new SpeakerModel() { Id = a.DictionarySpeakerId, Code = a.SpeakerCode, Name = a.DictionarySpeakerName, Rating = (decimal)a.Rating, Nationality = a.Nationality, Picture = a.Picture  }).ToList();
            return speakModel;
        }
    }
}
