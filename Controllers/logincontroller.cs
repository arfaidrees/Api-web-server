using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class logincontroller : ControllerBase
    {
        private readonly AppDbcontext 
        public logincontroller(AppDbcontext appdbcontext)
            [HttpGet]
        [Route("api/getdata/{id}")]
        public async Task<IActionResult> GetData(int id)
        {
            var result = await AppDbcontext.GetDataAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        [Route("api/postdata")]
        public async Task<IActionResult> PostData([FromBody] DataModel data)
        {
            if (data == null)
            {
                return BadRequest();
            }
            var result = await AppDbcontext.SaveDataAsync(data);
            if (result == null)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(GetData), new { id = result.Id }, result);
        }

    }
}

