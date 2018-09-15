using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using FibonacciTDD.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FibonacciTDD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        // GET: api/Fibonacci
        [HttpGet]
        public string Get()
        {
            return "Use api/fibonacci/{root} to calculate the fibonacci value of a root value";
        }

        // GET: api/fibonacci/5
        [HttpGet("{root}", Name = "Get")]
        public string Get(int root)
        {
            FibonacciCalculator Calculator = new FibonacciCalculator();
            return Calculator.CalculateValue(root).ToString();
        }

        ////// POST: api/Fibonacci
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Fibonacci/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
