using DSR_BL.DSR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using UTILITY.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DSRApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class TestController : ControllerBase
    {
        private IDsrBL _dsrBL;

        public TestController(IDsrBL dsrBL)
        {
            this._dsrBL = dsrBL;

        }

        // GET: api/<TestController>
        [HttpGet("GetDSRData")]
         public IActionResult GetDSRData()
        {
            try
            {
                return Ok(_dsrBL.GetDSRData());
            }
            catch (System.Exception ex)
            {
                return BadRequest(new
                {
                    data = ex.ToString()
                });
            }

          }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
