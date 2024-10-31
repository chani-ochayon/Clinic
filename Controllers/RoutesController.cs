using Cinic_Project.Entities;
using ClinicProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        private static List<RoutesClass> routes = new List<RoutesClass> {
        new RoutesClass{TimeStart = "07:10",TimeEnd="16:30",PatientId=1,DoctorId=1 },
        new RoutesClass{TimeStart = "16:30",TimeEnd="20:30",PatientId=2,DoctorId=2 }

         };

        // GET: api/<RoutesController>
        [HttpGet]
        public IEnumerable<RoutesClass> Get()
        {
            return routes;
            
        }

        // GET api/<RoutesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RoutesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RoutesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RoutesClass value)
        {
            var index = routes.FindIndex(x => x.Id == id);
            routes[index] = value;
        }

        // DELETE api/<RoutesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
