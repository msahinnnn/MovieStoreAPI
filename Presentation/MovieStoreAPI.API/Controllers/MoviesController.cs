using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreAPI.Application.Repositories;
using MovieStoreAPI.Domain.Entities;

namespace MovieStoreAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        readonly private IMovieWriteRepository _movieWriteRepository;
        readonly private IMovieReadRepository _movieReadRepository;

        public MoviesController(IMovieWriteRepository movieWriteRepository, IMovieReadRepository movieReadRepository)
        {
            _movieWriteRepository = movieWriteRepository;
            _movieReadRepository = movieReadRepository;
        }

        
        [HttpGet]
        public async Task Get()
        {
            
            _movieWriteRepository.AddAsync(
                new (){ MovieName = "Matrix 1", Duration = 3.20F, Price = 2.99F, CreateDate = DateTime.UtcNow } );
            _movieWriteRepository.SaveAsync();


        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Movie movie = await _movieReadRepository.GetByIdAsync(id);
            return Ok(movie);
        }
    }
}
