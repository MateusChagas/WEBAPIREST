using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WEBAPIREST.Model;
using WEBAPIREST.Business;

namespace WEBAPIREST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        private IPersonBusiness _personBusiness;

        public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness)
        {

            _logger = logger;
            _personBusiness = personBusiness;

        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }

        [HttpGet("{id}")]

        public IActionResult Get(long id)
        {
            var person = _personBusiness.FindById(id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        [HttpPost]

        public IActionResult Post([FromBody] Person person)
        {

            if (person == null)
            {
                return BadRequest();
            }

            return Ok(_personBusiness.Create(person));
        }

        [HttpPut]

        public IActionResult Put([FromBody] Person person)
        {

            if (person == null)
            {
                return BadRequest();
            }

            return Ok(_personBusiness.Update(person));
        }

        [HttpDelete]

        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }

    }
}
