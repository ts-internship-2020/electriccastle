using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Repository.Ef.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConferencePlanner.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : Controller
    {
        // GET: api/<TypeController>
        private readonly IConferenceTypeRepository conferenceType;
        public TypeController(IConferenceTypeRepository conferenceType)
        {

            this.conferenceType = conferenceType;
        }


        [HttpGet]
        [Route("{TypeName}")]
        public IActionResult GetDemo()
        {
            List<ConferenceTypeModel> typeModels = conferenceType.getAllTypes();
            return Ok(typeModels);
        }

       
        // POST api/<TypeController>
        [HttpPost] //add, edit
        [Route("{Id}")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Post(int Id,ConferenceTypeModel conferenceTypeModel)
        {
            conferenceTypeModel.ConferenceTypeId = Id;
            conferenceType.getType(conferenceTypeModel);
            return Ok(conferenceType);
        }


        [HttpPost]
     
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Post( ConferenceTypeModel conferenceTypeModel)
        {
            
            conferenceType.insertType(conferenceTypeModel);
            return Ok(conferenceTypeModel);
        }

        // PUT api/<TypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TypeController>/5
        [HttpDelete]
        [Route("{Type}")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult DeleteDemo(int index)
        {
          
            conferenceType.deleteType(index);
            return Ok();
        }
    }
}
