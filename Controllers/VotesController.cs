using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using WebApplication.Models;

    [ApiController]
    [Route("[controller]")]
    [EnableCors("MyPolicy")]
    public class VotesController : ControllerBase
    {
        private readonly IAnonymousEurosongDataContext _data;

        public VotesController(IAnonymousEurosongDataContext data)
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
        }

        [HttpGet]
        public ActionResult<IEnumerable<Vote>> Get()
        {
            return Ok(_data.GetVotes());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Vote vote)
        {
            _data.AddVote(vote);
            return Ok("Vote added successfully");
        }

        [HttpGet("{id}")]
        public ActionResult<Vote> Get(int id)
        {
            Vote v = _data.GetVote(id);
            if (v != null) return Ok(v);
            return NotFound("Vote not found! Try another ID!");
        }
    }
}
