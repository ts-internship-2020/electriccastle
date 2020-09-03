using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.ElectricCastleModel;

namespace ConferencePlanner.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConferenceParticipantsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IParticipantsConferencesRepository _getParticipantsConferencesRepository;

        public ConferenceParticipantsController(ILogger<HomeController> logger, IParticipantsConferencesRepository getParticipantsConferencesRepository)
        {
            _logger = logger;
            _getParticipantsConferencesRepository = getParticipantsConferencesRepository;
        }

        [HttpGet]
        [Route("ParticipantsConference")]
        public IActionResult GetParticipantsConferences()
        {
            List<ParticipantsConferencesModel> confernse = _getParticipantsConferencesRepository.GetParticipantsConferences();
            return Ok(confernse);
        }

        [HttpPost]
        [Route("ParticipantState")]
        public IActionResult AddCity(int index, string email)
        {
            _getParticipantsConferencesRepository.UpdateParticipantsConferencesState(index, email);
            return Ok();
        }
    }
}
