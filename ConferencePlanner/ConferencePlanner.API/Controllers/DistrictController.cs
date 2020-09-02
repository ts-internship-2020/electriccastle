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
    public class DistrictController : Controller
    {
        private readonly IAddConferenceDistrictRepository _getDistrict;

        public DistrictController(IAddConferenceDistrictRepository getDistrict)
        {

            _getDistrict = getDistrict;
        }

        [HttpGet]
        [Route("{District}")]
        public IActionResult GetDistrict()
        {
            List<AddConferenceDistrictModel> demoModels = _getDistrict.GetConferencesDistrict();
            return Ok(demoModels);
        }

        [HttpPost]
     
        public IActionResult InsertCountry(AddConferenceDistrictModel conferenceDistrict)
        {
            _getDistrict.InsertConferenceDistrict(conferenceDistrict);
            return Ok();
        }

        [HttpDelete]
        [Route("{District}")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult DeleteDemo(int index)
        {
            //List<AddConferenceCountryModel> demoModels = _getCountry.GetConferencesCountry();
            _getDistrict.DeleteConferenceDistrict(index);
            return Ok();
        }

        [HttpPost]
        [Route("{Update}")]
        public IActionResult UpdateDistrict(AddConferenceDistrictModel conferenceDistrict)
        {
            _getDistrict.UpdateConferenceDistrict(conferenceDistrict);
            return Ok();
        }
    }
}
