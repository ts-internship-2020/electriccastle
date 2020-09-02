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
    public class ConferenceController : Controller
    {
        private readonly IConferenceRepository conferenceRepository;

        public ConferenceController(IConferenceRepository conferenceRepository)
        {
            this.conferenceRepository = conferenceRepository;
        }

        [HttpGet]
        [Route("{conferenceId}")]
        public IActionResult GetConference([FromRoute] int? conferenceId)
        {
            if (conferenceId == null)
            {
                return BadRequest();
            }
            ConferenceModel conference = conferenceRepository.GetConference((int)conferenceId);
            return Ok(conference);
        }

        [HttpPost]
        public IActionResult CreateConference(ConferenceModel conference)
        {
            conferenceRepository.AddConference(conference);
            return Ok();
        }

        [HttpPost]
        [Route("{conferenceId}")]
        public IActionResult UpdateConference([FromRoute] int? conferenceId, ConferenceModel conference)
        {
            if (conferenceId == null)
            {
                return BadRequest();
            }
            conference.ConferenceId = (int)conferenceId;
            conferenceRepository.EditConference(conference);
            return Ok();
        }

        [HttpDelete]
        [Route("{conferenceId}")]
        public IActionResult DeleteConference([FromRoute] int? conferenceId)
        {
            if (conferenceId == null)
            {
                return BadRequest();
            }
            //conferenceRepository.DeleteConference((int)conferenceId);
            return Ok();
        }
    }
}
