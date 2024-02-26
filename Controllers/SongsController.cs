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
}