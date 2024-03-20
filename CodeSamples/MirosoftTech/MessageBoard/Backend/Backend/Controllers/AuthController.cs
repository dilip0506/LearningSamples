using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Backend.Controllers
{
    public class JwtPacket {
        public string Token { get; set; }
        public String Name { get; set; }
    }

    public class LoginData {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    [Produces("application/json")]
    [Route("auth")]
    public class AuthController : Controller
    {
        readonly ApiContext context;
        public AuthController(ApiContext _context) {
            this.context = _context;
        }
        [HttpPost("register")]//sub route
        public JwtPacket Register([FromBody]Models.User user) {
            context.Users.Add(user);
            context.SaveChanges();
            return CreatJwtPacket(user);   
        }
        [HttpPost("login")]
        public ActionResult login([FromBody]LoginData loginData) {
            var user = context.Users.SingleOrDefault(users => users.Email == loginData.Email && users.Password == loginData.Password);
            if (user == null)
                return NotFound("No user found");
            return Ok(CreatJwtPacket(user));
        }     
        public JwtPacket CreatJwtPacket(Models.User user) {//Json web token
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("secretphraseexample"));
            var signinCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            var Claim = new Claim[] {
                new Claim(JwtRegisteredClaimNames.Sub,user.Id)//token now contain userid we identity request antenticate be need pass the token from client 
            };
            var jwt = new JwtSecurityToken(claims: Claim,signingCredentials:signinCredentials);//new jwt socket next we create token
            var encodesjwt = new JwtSecurityTokenHandler().WriteToken(jwt);//this will give us encoded token as string we need to convert it to json object for reponse, we use JwtPacket class
            return new JwtPacket { Token = encodesjwt, Name = user.FirstName };//token might be complex we can use a payload
        }
    }
}