using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace HttpStatus.Response
{
    public class ExceptionResponse : IHttpActionResult
    {
        private readonly string _value;
        private readonly HttpRequestMessage _request;
        public ExceptionResponse(string value, HttpRequestMessage request) {
            _value = value;
            _request = request;
        }

       
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var stringPayload = JsonConvert.SerializeObject(new { message = _value });
            HttpResponseMessage reponse = new HttpResponseMessage()
            {
                Content = new StringContent(stringPayload, Encoding.UTF8, "application/json"),
                RequestMessage = _request,
                StatusCode = HttpStatusCode.InternalServerError,
            };            
            reponse.Headers.CacheControl = new CacheControlHeaderValue()
            {
                MaxAge = new TimeSpan()
            };
        return Task.FromResult(reponse);
        }
    }
}