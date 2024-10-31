using ClinicProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {


        private static List<PatientClass> patients = new List<PatientClass> {
        new PatientClass{ Id=1,Name="Elisheva" ,Age=5,Mail="elish@gmail.com"},
        new PatientClass{Id=2,Name="aviva" ,Age=10,Mail="aviva@gmail.com" }

         };


        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<PatientClass> Get()
        {
            return patients;
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PatientController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
