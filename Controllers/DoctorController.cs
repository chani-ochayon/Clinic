using ClinicProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        private static List<DoctorClass> Doctors = new List<DoctorClass> {

        new DoctorClass { Name="ARIEL",Id=1,Foun="0588888888",WorkHours=0},
        new DoctorClass { Name="efraim",Id=2,Foun="058222288",WorkHours=0}
        };






    // GET: api/<DoctorController>
    [HttpGet]
        public IEnumerable<DoctorClass> Get()
        {
            return Doctors;
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DoctorClass value)
        {
           var index = Doctors.FindIndex(x => x.Id == id);
            Doctors[index] = value;
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
