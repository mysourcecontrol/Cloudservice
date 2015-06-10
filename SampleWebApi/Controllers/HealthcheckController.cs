using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebApi.Controllers
{
    public class HealthcheckController : ApiController
    {
        public HttpResponseMessage Get(bool? shutdown = null)
        {
            if (shutdown.HasValue && shutdown.Value)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Shutdown Instance");
            }

            var response = Request.CreateResponse(HttpStatusCode.OK, "Application is running");
            return response;
        }
    }
}
