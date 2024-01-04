using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services;
using DAL.Entities;
using DAL.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIRenaud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        
        private readonly AuthService _authService;
        
        public AuthController(AuthService authService)
        {
            _authService = authService;
        }
        
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginForm form)
        {
            User? user = _authService.Login(form);

            if (user is not null)
            {
                return Ok(user);
            }

            return NotFound();
        }
        
    }
}
