using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_2020._2._1.Controllers
{
    [ApiController]
    [Route("HelloWorld")]
    public class HelloWorldController : ControllerBase
    {
        public HelloWorldController(){}
        [HttpGet]
        public string Get()
        {
            //Qualquer coisa aqui dentro
            return "HelloWorld";
        }
    }
}
