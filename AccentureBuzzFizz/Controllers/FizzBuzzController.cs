using AccentureFizzBuzz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace AccentureBuzzFizz.Controllers
{
    /// <summary>
    /// Controller class to handles incoming HTTP requests and send response back to the caller.
    /// </summary>
    [Route("api/fizzbuzz")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        /// <summary>
        /// The Classic method returns the solution to the classic FizzBuzz problem as described in "Classic FizzBuzz"
        /// Method will return a list containing the classic Fizz buzz algorithm
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public List<string> getClassic()
        {
            Fizzbuzz classic = new Fizzbuzz();
            classic.runClassic();

            return classic.fizzbuzzResolved;
        }


        /// <summary>
        /// The Advanced method returns the solution to FizzBuzz challenge but with a different approach
        /// Method will return a list containing the advanced Fizz buzz algorithm with the following changes
        /// This controller method will return a list proccesed within class Fizzbuzz
        /// </summary>
        [HttpGet]
        [Route("advanced")]
        public List<string> getCustomRange()
        {
            Fizzbuzz classic = new Fizzbuzz();
            classic.runAdvanced();

            return classic.fizzbuzzResolved;
        }

        /// <summary>
        /// The Advanced method returns the solution to FizzBuzz challenge but with a different approach
        /// Method will return a list containing the advanced Fizz buzz algorithm with the following changes
        /// This controller method will return a list proccesed within class Fizzbuzz
        /// </summary>
        [HttpPost("custombyrange/{start_value}/{end_value}")]
        public List<string> getAdvanced([FromBody] JsonRequest s, string start_value, string end_value)
        {

            var list = s.divisorToken.ToList();

            var weatherForecast = s.end;

            Fizzbuzz classic = new Fizzbuzz();
            classic.runAdvanced();

            return classic.fizzbuzzResolved;
        }


    }
}
