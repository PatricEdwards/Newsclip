using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_API.Models;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolkswagenController : ControllerBase
    {
        private IVolkswagenData _volkswagenData;

        public VolkswagenController(IVolkswagenData volkswagenData)
        {
            _volkswagenData = volkswagenData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetVehicles()
        {
            return Ok(_volkswagenData.GetVehicles());
        }
     
        [HttpGet]
        [Route("api/[controller]/{Name}")]
        public IActionResult GetVehicle(string Name)
        {


            var vehicle = _volkswagenData.GetVehicle(Name);
            if (vehicle != null)
                return Ok(_volkswagenData.GetVehicle(Name));
            else
                return NotFound($"Vehicle Name: {Name} does not exist");

        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddVehicle(Vehicle ivehicle)
        {
            _volkswagenData.AddVehicle(ivehicle);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + ivehicle.Name, ivehicle);

        }


        [HttpDelete]
        [Route("api/[controller]/{Name}")]
        public IActionResult DeleteVehicle(string Name)
        {
            var vehicle = _volkswagenData.GetVehicle(Name);
            if (vehicle == null)
            {
                return NotFound($"Vehicle Name: {Name} does not exist");
            }

            return Ok(_volkswagenData.RemoveVehicle(Name));

        }

        [HttpPatch]
        [Route("api/[controller]/{Name}")]
        public IActionResult EditVehicle(string Name, Vehicle ivehicle)
        {
            var vehicle = _volkswagenData.GetVehicle(Name);
            if (vehicle == null)
            {
                return NotFound($"Vehicle Name: {Name} does not exist");
            }

            return Ok(_volkswagenData.EditVehicle(ivehicle));
        }



    }
}
