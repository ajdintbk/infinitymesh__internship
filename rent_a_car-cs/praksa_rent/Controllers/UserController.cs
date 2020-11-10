using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Praksa.Repositories.Repositories;
using praksa_rent.Domain;

namespace praksa_rent.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userRepository.GetTopTen();
            return Ok(users);
        }

        public IActionResult Delete(int Id)
        {
            _userRepository.Delete(Id);
            return Ok();
        }

        public IActionResult Add(string name, string surname, string email, string username, string password)
        {
            var newUser = new User()
            {
                Name = name,
                CityId = 1,
                Surname = surname,
                Email = email,
                Username = username,
                Password = password,
                Address = "Laticka"
            };
            var user = _userRepository.Add(newUser);
            return Ok(user);
        }
    }
}
