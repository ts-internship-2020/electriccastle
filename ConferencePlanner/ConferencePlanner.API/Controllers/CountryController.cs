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
    public class CountryController : Controller
    {
        private readonly IAddConferenceCountryRepository _getCountry;


        public CountryController(IAddConferenceCountryRepository getCountry)
        {

            _getCountry = getCountry;
        }

        [HttpGet]
        [Route("{Country}")]
        public IActionResult GetCountry()
        {
            List<AddConferenceCountryModel> demoModels = _getCountry.GetConferencesCountry();
            return Ok(demoModels);
        }


        [HttpPost]
        [Route("{Country}")]
        public IActionResult InsertCountry(string cod, string name)
        {
            _getCountry.InsertConferenceCountry(cod, name);
            return Ok();
        }

        [HttpPost]
        
        public IActionResult UpdateCountry(string cod, string name, int index)
        {
            _getCountry.UpdateConferenceCountry(cod, name, index);
            return Ok();
        }

        [HttpDelete]
        [Route("{Country}")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult DeleteCountry(int index)
        {
            //List<AddConferenceCountryModel> demoModels = _getCountry.GetConferencesCountry();
            _getCountry.DeleteConferenceCoutry(index);
           return Ok();
        }
    }
}
