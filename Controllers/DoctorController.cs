using ClinicProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public DoctorController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

    // GET: api/<DoctorController>
    [HttpGet]
        public IEnumerable<DoctorClass> Get()
        {
            return _dataContext.Doctors;
        }

        //// GET api/<DoctorController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] DoctorClass value)
        {
            _dataContext.Doctors.Add(value);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DoctorClass value)
        {
           var index = _dataContext.Doctors.FindIndex(x => x.Id == id);
            _dataContext.Doctors[index] = value;
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var index = _dataContext.Doctors.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.Doctors.RemoveAt(index);
                return Ok();
            }
            return NotFound();
}        }
}
