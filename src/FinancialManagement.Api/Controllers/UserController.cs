using FinancialManagement.Api.Models;
using FinancialManagement.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialManagement.Api.Controllers
    {
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
        {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
            {
            _userService = userService;
            }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
            {
            return await _userService.GetAllUsersAsync();
            }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
            {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null) return NotFound();
            return user;
            }

        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
            {
            var createdUser = await _userService.CreateUserAsync(user);
            return CreatedAtAction(nameof(GetUser), new { id = createdUser.Id }, createdUser);
            }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, User user)
            {
            if (id != user.Id) return BadRequest();
            await _userService.UpdateUserAsync(user);
            return NoContent();
            }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
            {
            await _userService.DeleteUserAsync(id);
            return NoContent();
            }
        }
    }
