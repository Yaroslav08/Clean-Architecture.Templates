using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classroom.Constants.WebApiResponses;
using CleanArchitecture.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace CleanArchitecture.WebApi.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly ILogger<UserController> logger;
        public UserController(ILogger<UserController> _logger, IUserService _userService)
        {
            logger = _logger;
            userService = _userService;
        }
        
        [HttpGet("api/users/{Id?}")]
        public async Task<IActionResult> GetUser(int? Id)
        {
            if (Id == null)
                return BadRequest(new APIBadRequestResponse(Constants.Constants.NotFound));
            return Ok(new APIOKResponse(await userService.GetUserById(Convert.ToInt32(Id))));
        }
    }
}