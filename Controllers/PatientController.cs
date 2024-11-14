using ClinicProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {

        private readonly DataContext _dataContext;
        public PatientController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<PatientClass> Get()
        {
            return _dataContext.Patients;
        }

        //// GET api/<PatientController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<PatientController>
        [HttpPost]
        public void Post([FromBody] PatientClass value)
        {
            _dataContext.Patients.Add(value);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] PatientClass value)
        {
            var index = _dataContext.Patients.FindIndex(x => x.Id == id);
            if (index == -1) { 
            _dataContext.Patients[index] = value;
                return Ok();
            }
            return NotFound();

        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var index = _dataContext.Patients.FindIndex(x =>x.Id == id);
            if (index != -1)
            {
                _dataContext.Patients.RemoveAt(index);
                return Ok();
            }
            return NotFound();
        }
    }
}
