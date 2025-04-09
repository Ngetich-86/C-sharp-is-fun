using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Models;
using Backend.Services;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers() =>
            await _userService.GetAllAsync();

        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            await _userService.CreateAsync(user);
            return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
        }
    }
}
