using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThoughtController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ThoughtController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Thought>>> GetThought()
        {
            return Ok(await _context.Thoughts.ToListAsync());
        }
        [HttpGet("{id}")]
        public ActionResult <Thought> GetThought(int id)
        {
            var thought = _context.Thoughts.Find(id);
            if(thought == null)
            {
                return NotFound();
            }
            return thought;
        }
        [HttpPost]
        public async Task<ActionResult<Thought>> Create(Thought thought)
        {
            _context.Add(thought);
            await _context.SaveChangesAsync();
            return Ok(thought);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Thought thought)
        {
            if (id != thought.Id)
                return BadRequest();
            _context.Entry(thought).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var thought = await _context.Thoughts.FindAsync(id);
            if (thought == null)
            {
                return NotFound();
            }
            _context.Thoughts.Remove(thought);
            await _context.SaveChangesAsync();
            return Ok();
        }

        

        //[HttpGet("search")]
        //public async Task<ActionResult<List<Thought>>> SearchThoughts([FromQuery] string searchTerm)
        //{
        //    var thoughts = await _context.Thoughts
        //        .Where(t => t.Name.Contains(searchTerm) || t.Text.Contains(searchTerm))
        //        .ToListAsync();

        //    return Ok(thoughts);
        //}

        //[HttpPost("search")]
        //public async Task<ActionResult<List<Thought>>> SearchThoughtsPost(string searchTerm)
        //{
        //    return await SearchThoughts(searchTerm);
        //}

        //[HttpGet("random")]
        //public async Task<ActionResult<List<Thought>>> GetRandomThoughts(int count)
        //{
        //    // Retrieve a random sample of thoughts from the database
        //    var randomThoughts = await _context.Thoughts.OrderBy(t => Guid.NewGuid()).Take(count).ToListAsync();

        //    return Ok(randomThoughts);
        //}
    }
}
