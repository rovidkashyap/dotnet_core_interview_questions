using AutoMapper;
using AutoMapper.Configuration;
using automapper_in_aspnet_core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace automapper_in_aspnet_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;
        public UsersController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = new User
            {
                Id = id,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            var userDto = _mapper.Map<UserDto>(user);

            return Ok(userDto);
        }
    }
}
