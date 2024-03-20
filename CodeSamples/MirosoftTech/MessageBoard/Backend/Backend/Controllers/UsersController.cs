using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Backend.Controllers
{
    public class EditProfileData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        readonly ApiContext context;
        public UsersController(ApiContext _context)
        {
            this.context = _context;
        }
        [HttpGet("{id}")]
        public ActionResult Get(string id) {
            var user = context.Users.SingleOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound("user not found");
            return Ok(user);
        }
        [Authorize]
        [HttpGet("me")]
        public ActionResult Get() {
            
            return Ok(GetSecureUser());
        }
        [Authorize]
        [HttpPost("me")]
        public ActionResult Post([FromBody]EditProfileData profileData)
        {

            var user = GetSecureUser();
            user.FirstName = profileData.FirstName ?? user.FirstName;
            user.LastName = profileData.LastName ?? user.LastName;
            context.SaveChanges();
            return Ok();
        }
        Models.User GetSecureUser()
        {

            var id = HttpContext.User.Claims.First().Value;//Claims will retun all the collection of claims we setup,here we have only one claim return the userid if we have more claim it may not retun the required claim
            //in future it maps to same name identifier//not best practise we may have more claims
            return context.Users.SingleOrDefault(u => u.Id == id);
        }
    }
}