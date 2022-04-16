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

        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;

        readonly private ICustomerWriteRepository _customerWriteRepository;

        
        public MoviesController(IMovieWriteRepository movieWriteRepository, IMovieReadRepository movieReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _movieWriteRepository = movieWriteRepository;
            _movieReadRepository = movieReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }


        [HttpGet]
        public async Task Get()
        {

            Order order = await _orderReadRepository.GetByIdAsync("5e559839-4ded-49ff-8d80-4c34dde39500");
            order.Address = "Ankara";
            await _orderWriteRepository.SaveAsync();


            //var customerId = Guid.NewGuid();
            //await _customerWriteRepository.AddAsync(new() { Id = customerId, CustomerName = "Tony Stark",  });

            //await _orderWriteRepository.AddAsync(new() { Description = "lorem ipsum", Address = "Istanbul, Kadikoy", CustomerId = customerId });
            //await _orderWriteRepository.AddAsync(new() { Description = "lorem ipsum", Address = "Istanbul, Ortakoy", CustomerId = customerId });
            //await _orderWriteRepository.SaveAsync();




            //_movieWriteRepository.AddAsync(
            //    new (){ MovieName = "Matrix 1", Duration = 3.20F, Price = 2.99F, CreateDate = DateTime.UtcNow } );
            //_movieWriteRepository.SaveAsync();


        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Movie movie = await _movieReadRepository.GetByIdAsync(id);
            return Ok(movie);
        }
    }
}
