using Microsoft.AspNetCore.Mvc;
using PoprawaKolokwium2.Exceptions;
using PoprawaKolokwium2.Services;

namespace PoprawaKolokwium2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetArtistController : ControllerBase
    {
        private IArtistsDbService _dbService;

        public GetArtistController(IArtistsDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetArtist(int id)
        {
            try
            {
                var result = _dbService.GetArtist(id);
                return Ok(result);
            }
            catch (NoArtistException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}