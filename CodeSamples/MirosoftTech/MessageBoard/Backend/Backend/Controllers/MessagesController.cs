using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Messages")]
    public class MessagesController : Controller
    {
        readonly ApiContext Context;
        public MessagesController(ApiContext _context) {
            this.Context = _context;
        }
        
        //static List<Models.Messages> MessageList = new List<Models.Messages>(){};
        //[HttpGet]
        //public IEnumerable<Models.Messages> Get() {            
        //    return Context.Messages; 
        //}

        //[HttpGet("{name}")]
        //public IEnumerable<Models.Messages> Get(string name)
        //{
        //    return this.Context.Messages.Where(MessageList => MessageList.Owner == name);
        //}

        [HttpPost]
        public Models.Messages Post(Models.Messages messages) {
            var dbMessage = this.Context.Messages.Add(messages).Entity;
            Context.SaveChanges();
            return dbMessage;
        }
    }
}