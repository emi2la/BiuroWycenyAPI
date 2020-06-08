using BiuroWycenyAPI.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroWycenyAPI.Controllers
{
    [Route("api/prices")]
    [ApiController]
    public class PriceController : ControllerBase
    {

        private readonly IPriceService _service;

        public PriceController(IPriceService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetPricees(string lastName)
        {
            var quests = _service.GetPriceCollection(lastName);

            return Ok(quests);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetPrice(int id)
        {

            return Ok(_service.GetPrice(id));
        }

        [HttpPost]
        public IActionResult AddPrice(PriceRequestDto newPrice)
        {
            if (_service.AddPrice(newPrice))
            {
                return Ok("New Price CREATED!!!");
            }
            else
            {
                return BadRequest("Price could not be CREATED!!! Something went wrong...");
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdatePrice(int id, PriceRequestDto updatePrice)
        {
            if (_service.UpdatePrice(id, updatePrice))
            {
                return Ok("Price sucessfully update!!!");
            }
            else
            {
                return BadRequest("Price could not be UPDATED!!! Something went wrong...");
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeletePrice(int id)
        {
            if (_service.DeletePrice(id))
            {
                return Ok($"Price with id {id} sucessfully deleted!!!");
            }
            else
            {
                return BadRequest("Price not found");
            }
        }
    }
}
