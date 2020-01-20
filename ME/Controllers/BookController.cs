using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ME.dll;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ME.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly MEDbContext context;

        public BookController(MEDbContext ctx)
        {
            context = ctx; 
        }

        // GET: api/Book
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var books = context.Books.ToList();
                return Ok(books);
            }
            catch (Exception ex)
            {
                return NotFound(); 
            }
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Book
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
