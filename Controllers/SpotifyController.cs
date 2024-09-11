using Jukebox.Services;
using Microsoft.AspNetCore.Mvc;

namespace Jukebox.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpotifyController : ControllerBase
    {
        private readonly ISpotifyService _spotifyService;

        public SpotifyController(ISpotifyService spotifyService)
        {
            _spotifyService = spotifyService;
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchAlbums([FromQuery] string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return BadRequest("Query must not be empty");
            }
            var albums = await _spotifyService.SearchAlbumsAsync(query, 10);

            if (albums == null)
            {
                return NotFound("No albums found");
            }

            return Ok(albums);

        }
    }
}