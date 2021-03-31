using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using OnlineCourse.Models;


namespace OnlineCourse.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class registrationController : ApiController
    {
        onlinecourseEntities entities = new onlinecourseEntities();

    }
}
