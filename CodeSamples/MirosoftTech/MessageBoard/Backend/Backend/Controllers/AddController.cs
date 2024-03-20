using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
   // [Produces("application/json")]
    [Route("api/Add")]
    public class AddController : Controller
    {
        readonly ApiContext context;
        public AddController(ApiContext _context)
        {
            this.context = _context;
        }
        public void Add() {
            context.Users.Add(new Models.User { Id = "1", Email = "as@gm.com", FirstName = "a", LastName = "a", Password = "a" });
           // context.Messages.Add(new Models.Messages { Id = "1", Owner = "a", Text = "hi" });
            context.SaveChanges();
        }
    }
}