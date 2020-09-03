using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConferencePlanner.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly IConferenceCategoryRepository conferenceCategory;
        public CategoryController(IConferenceCategoryRepository conferenceCategory)
        {

            this.conferenceCategory = conferenceCategory;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public IActionResult GetCategory()
        {
            List<ConferenceCategoryModel> categoryModels = conferenceCategory.GetAllCategories();
            return Ok(categoryModels);
        }





        // POST api/<CategoryController>
        [HttpPost] //add, edit
              
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Post(ConferenceCategoryModel conferenceCategoryModel)
        {
            conferenceCategory.EditCategory(conferenceCategoryModel);
            return Ok(conferenceCategoryModel);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult DeleteDemo(int index)
        {
            //List<AddConferenceCountryModel> demoModels = _getCountry.GetConferencesCountry();
            conferenceCategory.DeleteCategory(index);
            
            return Ok();
        }
    }
}
