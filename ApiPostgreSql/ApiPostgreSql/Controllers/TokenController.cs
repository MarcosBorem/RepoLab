using ApiPostgreSql.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApiPostgreSql.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ApiPostgreSqlContext _context;

        public TokenController(ApiPostgreSqlContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult GeneratorToken([FromBody] Loguin request)
        {
            if (request.User == "admin" && request.Password == "@orbi$2021")
            {

                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, request.User)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("cf83e1357eefb8bdf1542850d66d8007d620e4050b5715dc83f4a921d36ce9ce47d0d13c5d85f2b0ff8318d2877eec2f63b931bd47417a81a538327af927da3e"));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


                var token = new JwtSecurityToken(
                    issuer: "Jwt:Issuer",
                    audience: "Jwt:Audience",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(15),
                    signingCredentials: creds);
                var tokestring = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(tokestring);

            }
            return BadRequest("Credencial inválida!"); //401
        }
    }
}
