using BookAPI.Communication.Request;
using BookAPI.Communication.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        


        [HttpPost]
        [ProducesResponseType(typeof(ResponseIdNewBooks), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody]RequestCreateBook request)
        {
            var Response = new ResponseIdNewBooks
            {
                ID = 1

            };
        return Created(string.Empty, Response);
        }
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        public IActionResult UpdateInfoBooks([FromRoute] int id,
            [FromBody] RequestUpdateBookcs request)
        {
            return NoContent();  
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteBook([FromRoute]int id)
        {
            return NoContent();        
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetInfBooks([FromRoute] int id)
        {
            return Ok();
        }

    }

}