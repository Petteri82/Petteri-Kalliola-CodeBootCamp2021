using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Controllers
{
    [https://localhost:44354/weatherforecast("api/[controller]")]
    [ApiController]
    public class MyTestController : ControllerBase
    {
        public string Hello()
        {
            return "Hello World!";
        }
    }
}
