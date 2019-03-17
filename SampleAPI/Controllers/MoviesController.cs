using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleAPI.Models;

namespace SampleAPI.Controllers
{
	 [Route("api/")]
	 [ApiController]
	 [Produces("application/json")]
	 public class MoviesController : ControllerBase
	 {
		  private readonly SampleAPIContext _context;

		  public MoviesController(SampleAPIContext context)
		  {
				_context = context;
		  }

		  // GET: api/Movies
		  [HttpGet("[controller]")]
        public IEnumerable<Movie> GetMovie()
        {
            return _context.Movie;
        }

        // GET: api/Movie/5
        [HttpGet("Movie/{id}")]
        public async Task<IActionResult> GetMovie([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var movie = await _context.Movie.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        // PUT: api/Movie/5
        [HttpPut("Movie/{id}")]
        public async Task<IActionResult> PutMovie([FromRoute] long id, [FromBody] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != movie.ID)
            {
                return BadRequest();
            }

            _context.Entry(movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Movies
        [HttpPost("Movie")]
		  public async Task<IActionResult> PostMovie([FromBody] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
				try
				{
					 _context.Movie.Add(movie);
					 await _context.SaveChangesAsync();

					 return CreatedAtAction("GetMovie", new { id = movie.ID }, movie);
				}
				catch (Exception ex)
				{
					 throw;
				}
        }

        // DELETE: api/Movie/5
        [HttpDelete("Movie/{id}")]
        public async Task<IActionResult> DeleteMovie([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();

            return Ok(movie);
        }

        private bool MovieExists(long id)
        {
            return _context.Movie.Any(e => e.ID == id);
        }
    }
}