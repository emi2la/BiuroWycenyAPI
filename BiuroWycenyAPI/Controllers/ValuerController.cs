using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroWycenyAPI.Controllers
{
    [Route("api/valuers")]
    [ApiController]
    public class ValuerController : ControllerBase
    {

        private readonly IValuerService _service;

        public ValuerController(IValuerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetValueres(string lastName)
        {
            var quests = _service.GetValuerCollection(lastName);

            return Ok(quests);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetValuer(int id)
        {

            return Ok(_service.GetValuer(id));
        }

        [HttpPost]
        public IActionResult AddValuer(ValuerRequestDto newValuer)
        {
            if (_service.AddValuer(newValuer))
            {
                return Ok("New Valuer CREATED!!!");
            }
            else
            {
                return BadRequest("Valuer could not be CREATED!!! Something went wrong...");
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateValuer(int id, ValuerRequestDto updateValuer)
        {
            if (_service.UpdateValuer(id, updateValuer))
            {
                return Ok("Valuer sucessfully update!!!");
            }
            else
            {
                return BadRequest("Valuer could not be UPDATED!!! Something went wrong...");
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteValuer(int id)
        {
            if (_service.DeleteValuer(id))
            {
                return Ok($"Valuer with id {id} sucessfully deleted!!!");
            }
            else
            {
                return BadRequest("Valuer not found");
            }
        }
    }
}
