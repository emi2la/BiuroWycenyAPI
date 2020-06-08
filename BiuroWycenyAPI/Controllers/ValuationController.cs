using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroWycenyAPI.Controllers
{
    [Route("api/valuations")]
    [ApiController]
    public class ValuationController : ControllerBase
    {

        private readonly IValuationService _service;

        public ValuationController(IValuationService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetValuationes(string lastName)
        {
            var quests = _service.GetValuationCollection(lastName);

            return Ok(quests);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetValuation(int id)
        {

            return Ok(_service.GetValuation(id));
        }

        [HttpPost]
        public IActionResult AddValuation(ValuationRequestDto newValuation)
        {
            if (_service.AddValuation(newValuation))
            {
                return Ok("New Valuation CREATED!!!");
            }
            else
            {
                return BadRequest("Valuation could not be CREATED!!! Something went wrong...");
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateValuation(int id, ValuationRequestDto updateValuation)
        {
            if (_service.UpdateValuation(id, updateValuation))
            {
                return Ok("Valuation sucessfully update!!!");
            }
            else
            {
                return BadRequest("Valuation could not be UPDATED!!! Something went wrong...");
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteValuation(int id)
        {
            if (_service.DeleteValuation(id))
            {
                return Ok($"Valuation with id {id} sucessfully deleted!!!");
            }
            else
            {
                return BadRequest("Valuation not found");
            }
        }
    }
}
