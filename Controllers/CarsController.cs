using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gregslistSharpAuth.Models;
using gregslistSharpAuth.Services;
using Microsoft.AspNetCore.Mvc;

namespace gregslistSharpAuth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly CarsService _cs;

        public CarsController(CarsService cs)
        {
            _cs = cs;
        }
        [HttpGet]
        public ActionResult<List<Car>> Get()
        {
            try
            {
                List<Car> cars = _cs.Get();
                return Ok(cars);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<Car> Get(int id)
        {
            try
            {
                Car car = _cs.Get(id);
                return Ok(car);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public ActionResult<Car> Create([FromBody] Car carData)
        {
            try
            {
                Car car = _cs.Create(carData);
                return Created($"api/cars/{car.Id}", car);

            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public ActionResult<Car> Edit(int id, [FromBody] Car update)
        {
            try
            {
                update.Id = id;
                Car car = _cs.Edit(update);
                return Ok(car);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult<String> Delete(int id)
        {
            try
            {
                _cs.Delete(id);
                return Ok("Deleted");
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}