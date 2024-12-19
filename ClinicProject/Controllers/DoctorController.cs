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
        public ActionResult Put(int id, [FromBody] DoctorClass value)
        {

            if (value == null || _doctorService.IsExist(value))
            {
                return Conflict("doctor not found.");

            }
            _doctorService.UpdateDoctor(value);
            return Ok();
           
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if(id==0 || _doctorService.GetDoctorById(id)==null)
            
                return Conflict("wrong   id ");

            _doctorService.DeleteDoctor(id);
            return Ok();

}        }
}
