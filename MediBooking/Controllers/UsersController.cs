using MediBooking.Enums;
using MediBooking.Models;
using MediBooking.Services.UserServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<List<User>> GetUsers()
        {
            return await _userService.GetUsersAsync();
        }

        [HttpPost]
        public async Task<bool> CreateUser([FromBody] User newUser)
        {
            return await _userService.CreateUser(newUser);
        }

        [HttpDelete]
        public async Task<bool> DeleteUser(User userToDelete)
        {
            return await _userService.DeleteUser(userToDelete);
        }

        [HttpPut]
        public async Task<bool> UpdateUser(User userToUpdate)
        {
            return await _userService.UpdateUser(userToUpdate);
        }

        [HttpGet("{id}")]
        public async Task<User> GetUserById([FromRoute] int id)
        {
            return await _userService.GetUserById(id);
        }

        [HttpGet("patients")]
        public async Task<List<User>> GetPatients()
        {
            var allUsers = await _userService.GetUsersAsync();
            var patients = allUsers.Where(u => u.UserRole == UserRole.Patient).ToList();

            return patients;
        }

        [HttpGet("femaledoc")]
        public async Task<List<User>> GetFemaleDocs()
        {
            var allUsers = await _userService.GetUsersAsync();
            var femaleDocs = allUsers.Where(d => d.Sex == Sex.Female && d.UserRole == UserRole.Doctor).ToList();

            return femaleDocs;
        }
    }
}
