using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebApplication.Models;

[ApiController]
[Route("[controller]")]
[EnableCors("MyPolicy")]
public class SongsController : ControllerBase
{
    // Controller code...


private readonly IAnonymousEurosongDataContext _data;

    public SongsController(IAnonymousEurosongDataContext data)
    {
        _data = data ?? throw new ArgumentNullException(nameof(data));
    }

    [HttpGet]
    public ActionResult<IEnumerable<Song>> Get()
    {
        return Ok(_data.GetSongs());
    }

    [HttpPost]
    public ActionResult Post([FromBody] Song song)
    {
        _data.AddSong(song);
        return Ok("Hooray");
    }
    [HttpGet("{id}")]
    public ActionResult<Song> Get(int id)
    {
        Song s = _data.GetSong(id);
        if (s != null) return Ok(s);
        return NotFound("Song not found! Try another ID!");
    }

    [HttpGet("{id}/votes")]
    public ActionResult<IEnumerable<Vote>> GetSongVotes(int id)
    {
        var songVotes = _data.GetVote(id);
        return Ok(songVotes);
    }

    [HttpGet("{id}/points")]
    public ActionResult<int> GetSongPoints(int id)
    {
        var songPoints = _data.CalculateSongPoints(id);
        return Ok(songPoints);
    }

}