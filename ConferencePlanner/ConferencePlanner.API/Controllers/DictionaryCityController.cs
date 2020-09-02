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
    public class DictionaryCityController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAddConferenceCityRepository _getDictionaryCityRepository;

        public DictionaryCityController(ILogger<HomeController> logger, IAddConferenceCityRepository getDictionaryCityRepository)
        {
            _logger = logger;
            _getDictionaryCityRepository = getDictionaryCityRepository;
        }

        [HttpGet]
        [Route("City")]
        public IActionResult GetCity([FromRoute] string cityName)
        {
            List<AddConferenceCityModel> cityModels = _getDictionaryCityRepository.GetConferencesCity();
            return Ok(cityModels);
        }

        [HttpPost]
        [Route("UpdateCity")]
        public IActionResult UpdateCity([FromBody] AddConferenceCityModel city)
        {
            _getDictionaryCityRepository.updateCity(city.DictionaryCityId, city.CityCode, city.DictionaryCityName, city.DictionaryDistrictId);
            return Ok();
        }

        [HttpPost]
        [Route("AddCity")]
        public IActionResult AddCity([FromBody] AddConferenceCityModel city)
        {
            _getDictionaryCityRepository.insertCity(city.DictionaryCityId, city.DictionaryDistrictId, city.CityCode, city.DictionaryCityName);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteCity")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult DeleteCity(int cityId)
        {
            _getDictionaryCityRepository.deleteCity(cityId);
            return Ok();
        }
    }
}
