using Microsoft.AspNetCore.Mvc;
using ClinicProject.Core.Entities;
using ClinicProject.Core.Services;
using ClinicProject.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {

        private IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }


        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<PatientClass> Get()
        {
            return _patientService.GetPatients();
        }

       

        // POST api/<PatientController>
        [HttpPost]
        public ActionResult Post([FromBody] PatientClass value)
        {
            if (_patientService.IsExist(value))
            {
                // אם הרופא קיים, מחזירים תשובה מתאימה
                return Conflict(" Patient already exists.");
            }
            else if (value == null) {
                return Conflict("Patient is null.");
            }
            _patientService.Addpatient(value);
            return Ok();
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] PatientClass value)
        {
            var index = _patientService.GetPatients().ToList().FindIndex(x => x.Id == id);
            if (index == -1) {
                _patientService.GetPatients().ToList()[index] = value;
                return Ok();
            }
            return NotFound();

        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var index = _patientService.GetPatients().ToList().FindIndex(x =>x.Id == id);
            if (index != -1)
            {
                _patientService.GetPatients().ToList().RemoveAt(index);
                return Ok();
            }
            return NotFound();
        }
    }
}
