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
        public List<string> GetClassic()
        {
            Fizzbuzz classic = new();
            classic.RunClassic();

            return classic.fizzbuzzResolved;
        }


        /// <summary>
        /// The Advanced method returns the solution to FizzBuzz challenge but with a different approach
        /// Method will return a list containing the advanced Fizz buzz algorithm with the following changes
        /// This controller method will return a list proccesed within class Fizzbuzz
        /// </summary>
        [HttpGet]
        [Route("advanced")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public List<string> GetCustomRange()
        {
            Fizzbuzz classic = new ();
            classic.RunAdvanced();

            return classic.fizzbuzzResolved;
        }

        /// <summary>
        /// The Advanced method returns the solution to FizzBuzz challenge but with a different approach
        /// Method will return a list containing the advanced Fizz buzz algorithm with the following changes
        /// This controller method will return a list proccesed within class Fizzbuzz
        /// </summary>
        [HttpPost("custombyrange/{start_value}/{end_value}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]


        public ActionResult<List<string>> Custombyrange([FromBody] CustomRequest req, int start_value, int end_value)
        {
            try
            {
                IDictionary<string, int> list = new Dictionary<string, int>();
                if (req.divisorToken != null) list = req.divisorToken;


                var startValue = start_value;
                var endValue = end_value;

                Fizzbuzz customByRange = new();
                customByRange.CustomByRange(list, startValue, endValue);

                return customByRange.fizzbuzzResolved;
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        /// <summary>
        /// The CustomSet method returns the solution to FizzBuzz challenge but with a CustomSet approach
        /// Method will return a list containing the advanced Fizz buzz algorithm with the following changes
        /// This controller method will return a list proccesed within class Fizzbuzz
        /// </summary>
        [HttpPost("customSet")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]


        public ActionResult<List<string>> CustomSet([FromBody] CustomSetRequest req)
        {
            List<int> list =  new ();
            if (req.setofIntergers is not null) list = req.setofIntergers;


            Fizzbuzz customByRange = new();
            if (req.divisorToken is not null && list is not null)
            {
                customByRange.CustomSet(list, req.divisorToken);
                return customByRange.fizzbuzzResolved;
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
