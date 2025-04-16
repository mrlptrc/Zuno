using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zuno.Application.DTOs;
using Zuno.Application.Services;

namespace Zuno.Api.Controllers {

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase {

        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll() => Ok(await _userService.GetAllAsync());

        [HttpPost]
        public async Task<ActionResult> Create(UserDTO dto) {
            await _userService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetAll), null);
        }
    } 
}
