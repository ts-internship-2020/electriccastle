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
    public class SpeakerDetailController : Controller
    {
        private readonly ISpeakerDetailRepository speakerDetailRepository;

        public SpeakerDetailController(ISpeakerDetailRepository speakerDetailRepository)
        {
            this.speakerDetailRepository = speakerDetailRepository;
        }

        [HttpGet]
        public IActionResult GetSpeakerDetail()
        {
            List<SpeakerDetailModel> speakerDetails = speakerDetailRepository.GetSpeakerDetail();
            return Ok(speakerDetails);
        }
    }
}
