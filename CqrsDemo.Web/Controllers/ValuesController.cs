using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CqrsDemo.Web.Application.Commands;
using CqrsDemo.Web.SeedWorks;
using MediatR;

namespace CqrsDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IMediator _mediator;

        public ValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var cands = new List<CandidateDto>
            {
                new CandidateDto(1, "jon", "doe", 2, ".net"),
                new CandidateDto(2, "rahul", "doe", 3, "java")
            };
            
            var command = new CreateCentreCommand(1, "centre1", "India", "Odisa", "city1", cands);

            var r = _mediator.Send(command);

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
