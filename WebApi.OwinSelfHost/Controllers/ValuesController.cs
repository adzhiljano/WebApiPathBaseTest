using System.Collections.Generic;
using System.Web.Http;

namespace WebApi.Owin.Host.SystemWeb.Controllers
{
    [RoutePrefix("values")]
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
