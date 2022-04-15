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
            await _movieWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), MovieName = "LOTR 1", Duration = "3.30", CreateDate = DateTime.UtcNow, Price = 4.99 },
                new() { Id = Guid.NewGuid(), MovieName = "LOTR 2", Duration = "4.30", CreateDate = DateTime.UtcNow, Price = 5.99 },
                new() { Id = Guid.NewGuid(), MovieName = "LOTR 3", Duration = "5.30", CreateDate = DateTime.UtcNow, Price = 6.99 }
            });
            var count = await _movieWriteRepository.SaveAsync();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Movie movie = await _movieReadRepository.GetByIdAsync(id);
            return Ok(movie);
        }
    }
}
