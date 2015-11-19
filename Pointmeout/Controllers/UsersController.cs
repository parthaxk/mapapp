using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pointmeout.Controllers
{
      [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
          
          [HttpGet]
      [Route("currentlocation")]
          public string CurrentLocations()
          {
              return "ok" ;
          }

          [HttpPost]
          [Route("setlocation")]
          public HttpResponseMessage UpdateLocation(string name,string geolocation)
          {
              return new HttpResponseMessage(HttpStatusCode.OK);
          }

    }
}
