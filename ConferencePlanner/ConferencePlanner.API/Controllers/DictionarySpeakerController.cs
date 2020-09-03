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
    public class DictionarySpeakerController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISpeakerRepository _getSpeakerRepository;

        public DictionarySpeakerController(ILogger<HomeController> logger, ISpeakerRepository getSpeakerRepository)
        {
            _logger = logger;
            _getSpeakerRepository = getSpeakerRepository;
        }

        [HttpGet]
        [Route("Speaker")]
        public IActionResult GetSpeaker([FromRoute] string speakerName)
        {
            List<SpeakerModel> speakerModels = _getSpeakerRepository.GetSpeaker();
            return Ok(speakerModels);
        }

        [HttpPost]
        [Route("UpdateSpeaker")]
        public IActionResult UpdateSpeaker([FromBody] SpeakerModel speaker)
        {
            _getSpeakerRepository.editSpeaker(speaker.Id, speaker.Code, speaker.Name, speaker.Rating, speaker.Nationality,speaker.Picture);
            return Ok();
        }

        [HttpPost]
        [Route("AddSpeaker")]
        public IActionResult AddSpeaker([FromBody] SpeakerModel speaker)
        {
            _getSpeakerRepository.addSpeaker(speaker.Id, speaker.Code, speaker.Name, speaker.Rating, speaker.Nationality, speaker.Picture);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteSpeaker")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult DeleteSpeaker(int speakerId)
        {
            _getSpeakerRepository.deleteSpeaker(speakerId);
            return Ok();
        }
    }
}
