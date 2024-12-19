using Microsoft.AspNetCore.Mvc;
using ClinicProject.Core.Entities;
using ClinicProject.Core.Services;
using ClinicProject.Service;




// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class RoutesController : ControllerBase
    {
        private IRoutesService _routesService;
        public RoutesController(IRoutesService routesService)
        {
            _routesService = routesService;
        }

        // GET: api/<RoutesController>
        [HttpGet]
        public IEnumerable<RoutesClass> Get()
        {
            return _routesService.GetRoutes();
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
        public ActionResult Post([FromBody] RoutesClass value)
        {
            if (_routesService.IsExist(value))
            {
                // אם הרופא קיים, מחזירים תשובה מתאימה
                return Conflict(" Route already take one's place.");
            }
            else if (value == null)
            {
                return Conflict("Route is null.");
            }
            _routesService.AddRoute(value);
            return Ok();
        }

        // PUT api/<RoutesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RoutesClass value)
        {
            var index = _routesService.GetRoutes().ToList().FindIndex(x => x.Id == id);
            _routesService.GetRoutes().ToList()[index] = value;
        }

        // DELETE api/<RoutesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            var index = _routesService.GetRoutes().ToList().FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _routesService.GetRoutes().ToList().RemoveAt(index);
                return Ok();
            }
            return NotFound();

        }
    }
}
