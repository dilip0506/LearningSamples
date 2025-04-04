using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Description;
using Dapper;
using HttpStatus.Common;

namespace HttpStatus.Controllers
{
    public class Person
    {
        public int PersonId { get; set; }
        public int StreetId { get; set; }
        public DateTime DateOfBuy { get; set; }
    }

    public class StatusCodeController : ApiController
    {
        private readonly SqlConnection con = null;

        public StatusCodeController()
        {
            con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Integrated Security = True");
        }

        [Route("get/{personid}")]
        [HttpGet]
        public IHttpActionResult Get(int personid)
        {
            try
            {
                //   var orderDictionary = new Dictionary<int, Order>();
                using (con)
                {
                    return Ok(con.Query<Person>("select * from persons"));
                }
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, new {message = ex.Message});
                // return new ExceptionResponse(ex.Message, Request);
            }
        }

        [Route("put")]
        [HttpPut]
        public IHttpActionResult Put(Person person)
        {
            try
            {
                using (con)
                {
                      var deadlock = new DeadLock();
                      return Ok(deadlock.RetryDeadLock<int>(() =>
                      {
                          return con.Execute("update Persons set streetId = @steetid where PersonID = @personid ",
                              new {steetid = person.StreetId, personid = person.PersonId});
                      }));
                }
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, new {message = ex.Message});
                // return new ExceptionResponse(ex.Message, Request);
            }
        }
    }
}
