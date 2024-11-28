using ClinicProject.Core.Entities;
using ClinicProject.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
      private IDoctorService _doctorService;
      public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

    // GET: api/<DoctorController>
    [HttpGet]
        public IEnumerable<DoctorClass>Get()
        {
            return _doctorService.GetDoctor();
        }

        //// GET api/<DoctorController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<DoctorController>
        [HttpPost]
        public ActionResult Post([FromBody] DoctorClass value)
        {
            if (value==null || _doctorService.IsExist(value))
            {
                // אם הרופא קיים, מחזירים תשובה מתאימה
                return Conflict("Doctor already exists.");
            }
            _doctorService.AddDoctor(value);
            return Ok();
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DoctorClass value)
        {
           var index =_doctorService.GetDoctor().FindIndex(x => x.Id == id);
            _doctorService.GetDoctor()[index] = value;
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var index = _doctorService.GetDoctor().FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _doctorService.GetDoctor().RemoveAt(index);
                return Ok();
            }
            return NotFound();
}        }
}
