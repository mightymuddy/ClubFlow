using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vereinsportal.Components;

namespace Vereinsportal.Interfaces

{
    //This Controller is made for all functionallities depending on the clubs
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        //CRUD
        //Create
        //Read
        //Update
        //Delete

        [HttpPost]
        public IActionResult CreateClub([FromBody] Club club)
        {
            //TODO: add prodict to db
            return Ok();
        }
    }
}
