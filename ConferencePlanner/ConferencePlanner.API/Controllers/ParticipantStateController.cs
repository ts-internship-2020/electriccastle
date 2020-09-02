using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.ElectricRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConferencePlanner.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantStateController : Controller
    {
        private readonly IDictionaryParticipantState _getState;

        public ParticipantStateController(IDictionaryParticipantState getState)
        {
            _getState = getState;
        }

        [HttpGet]
        [Route("{ParticipantState}")]
        public IActionResult GetDistrict(string state)
        {
            List<ParticipantStateDemo> demoModels = _getState.GetDictionaryParticipantStates(state);
            return Ok(demoModels);
        }

    }
}
