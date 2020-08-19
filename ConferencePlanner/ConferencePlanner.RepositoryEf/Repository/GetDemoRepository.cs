using ConferencePlanner.Abstraction.Model;
using ConferencePlanner.Abstraction.Repository;
using ConferencePlanner.Repository.Ef.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferencePlanner.Repository.Ef.Repository
{
    public class GetDemoRepository : IGetDemoRepository
    {
        private readonly neverseaContext _dbContext;

        public GetDemoRepository(neverseaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<DemoModel> GetDemo(string name)
        {
            List<Demo> demos = _dbContext.Demo.ToList();

            List<DemoModel> demoModels = demos.Select(a => new DemoModel() { Id = a.Id, Name = a.Name }).ToList();

            return demoModels;
        }
    }
}
