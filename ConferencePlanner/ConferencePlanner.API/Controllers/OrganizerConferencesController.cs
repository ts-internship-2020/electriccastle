using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConferencePlanner.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizerConferencesController : Controller
    {
        private readonly IOrganizerConferencesRepository organizerConferencesRepository;

        public OrganizerConferencesController(IOrganizerConferencesRepository organizerConferencesRepository)
        {
            this.organizerConferencesRepository = organizerConferencesRepository;
        }

        [HttpGet]
        [Route("{email}")]
        public IActionResult GetAllConferencesForOrganizer(string email)
        {
            List<OrganizerConferencesModel> conferences = organizerConferencesRepository.GetConferencesForOrganizer(email);
            return Ok(conferences);
        }
    }
}
