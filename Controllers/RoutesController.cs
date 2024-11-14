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
        private readonly DataContext _dataContext;
        public RoutesController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // GET: api/<RoutesController>
        [HttpGet]
        public IEnumerable<RoutesClass> Get()
        {
            return _dataContext.routes;
            
        }

        //// GET api/<RoutesController>/5
        //[HttpGet("{id}")]
        //public RoutesClass Get(int id)
        //{

        //    var index = routes.FindIndex(x => x.Id == id);
        //    return routes[index];

        //}

        // POST api/<RoutesController>
        [HttpPost]
        public void Post([FromBody] RoutesClass value)
        {
            _dataContext.routes.Add(value);
        }

        // PUT api/<RoutesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RoutesClass value)
        {
            var index = _dataContext.routes.FindIndex(x => x.Id == id);
            _dataContext.routes[index] = value;
        }

        // DELETE api/<RoutesController>/5
        [HttpDelete("{id}")]
        public  ActionResult Delete(int id)
        {

            var index = _dataContext.routes.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.routes.RemoveAt(index);
                return Ok();
            }
            return NotFound();
           
        }
    }
}
