using ConferencePlanner.Abstraction.Model;
using ConferencePlanner.Abstraction.Repository;
using ConferencePlanner.Repository.Ef.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferencePlanner.Repository.Ef.Repository
{
    public class GetDemoRepository : IGetDemoRepository
    {
        private readonly electriccastleContext _electriccastleContext;

        public GetDemoRepository(electriccastleContext electriccastleContext)
        {
            _electriccastleContext = electriccastleContext;

        }

        public List<DemoModel> GetDemo(string name)
        {
            List<Conference> conferences = _electriccastleContext.Conference.ToList();

            //join
            List<Conference> conferencesjoin = _electriccastleContext.Conference.Include(x=>x.DictionaryConferenceCategory).ToList();

            //Conference conference = _electriccastleContext.Conference.FirstOrDefault(x => x.ConferenceName == "test");


            // List<DemoModel> demoModels = conferences.Select(a => new DemoModel() { Id = a.ConferenceId, Name = a.ConferenceName }).ToList();
            List<DemoModel> demoModels = conferencesjoin.Select(a => new DemoModel() { Id = a.ConferenceId, Name = a.ConferenceName }).ToList();
            return demoModels;
        }
    }
}
