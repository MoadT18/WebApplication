using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    // ArtistsController.cs

    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using WebApplication.Models;

    [ApiController]
    [Route("[controller]")]
    [EnableCors("MyPolicy")]
    public class ArtistsController : ControllerBase
    {
        private readonly IAnonymousEurosongDataContext _data;

        public ArtistsController(IAnonymousEurosongDataContext data)
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
        }

        [HttpGet]
        public ActionResult<IEnumerable<Artist>> Get()
        {
            return Ok(_data.GetArtists());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Artist artist)
        {
            _data.AddArtist(artist);
            return Ok("Artist added successfully");
        }

        [HttpGet("{id}")]
        public ActionResult<Artist> Get(int id)
        {
            Artist a = _data.GetArtist(id);
            if (a != null) return Ok(a);
            return NotFound("Artist not found! Try another ID!");
        }

        [HttpGet("{id}/songs")]
        public ActionResult<IEnumerable<Song>> GetArtistSongs(int id)
        {
            var artistSongs = _data.GetSong(id);
            return Ok(artistSongs);
        }
    }

}
