using apiTemplate.Models;
using apiTemplate.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace apiTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IGenericRepository<Movie> _movieRepo;
        public MoviesController(IGenericRepository<Movie> movieRepo)
        {
            _movieRepo = movieRepo;
        }

        [HttpGet]

        public IEnumerable Get()
        {
            return _movieRepo.GetAll();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Movie movie)
        {
            /* if (movie == null)
                 return BadRequest(ModelState);
             if (_movieRepo.MovieExists(movie.Title))
             {
                 ModelState.AddModelError("", "Movie already Exist");
                 return StatusCode(500, ModelState);
             }

             if (!_movieRepo.CreateMovie(movie))
             {
                 ModelState.AddModelError("", $"Something went wrong while saving movie record of {movie.Title}");
                 return StatusCode(500, ModelState);
             }*/

            return movie == null ? BadRequest(ModelState) : Ok(_movieRepo.Insert(movie));


        }

        [HttpPut]
        public IActionResult Update(int movieId, [FromBody] Movie movie)
        {
            /*if (movie == null || movieId != movie.IdMovie)
                return BadRequest(ModelState);

            if (_movieRepo.Update(movie) != null)
            {
                ModelState.AddModelError("", $"Something went wrong while updating movie : {movie.Title}");
                return StatusCode(500, ModelState);
            }

            return NoContent();*/
            return movie == null ? BadRequest(ModelState) : Ok(_movieRepo.Update(movie));
        }


        [HttpDelete]
        public IActionResult Delete(Movie movie)
        {
            /*if (!_movieRepo.MovieExists(movieId))
            {
                return NotFound();
            }

            var movieobj = _movieRepo.GetMovie(movieId);

            if (!_movieRepo.DeleteMovie(movieobj))
            {
                ModelState.AddModelError("", $"Something went wrong while deleting movie : {movieobj.Title}");
                return StatusCode(500, ModelState);
            }

            return NoContent();*/
            return movie == null ? BadRequest(ModelState) : Ok(_movieRepo.Delete(movie));
        }

    }
}
