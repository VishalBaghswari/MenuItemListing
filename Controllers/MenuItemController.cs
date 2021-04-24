using MenuItemListing.Model;
using MenuItemListing.Model.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MenuItemController : ControllerBase
    {
        private readonly ILogger _logger;

        
        private readonly IDataRepository<MenuItem> _dataRepository;
        public MenuItemController(IDataRepository<MenuItem> dataRepository, ILogger<MenuItemController> logger)
        {
            _dataRepository = dataRepository;
            _logger = logger;
        }
        // GET: api/Employee
        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Start : Getting item details for Get");
            IEnumerable<MenuItem> menuitems = _dataRepository.GetAll();
            _logger.LogInformation($"Completed : Item details are { string.Join(", ", menuitems) }");

            return Ok(menuitems);
        }
        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            _logger.LogInformation("Start : Getting item details for {ID}", id);
            string menuname = _dataRepository.Get(id);
            if (menuname == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
            _logger.LogInformation($"Completed : Item details are { string.Join(", ", menuname) }");
            return Ok(menuname);
        }

        // POST api/<MenuItemController>
        /*[HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MenuItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MenuItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
