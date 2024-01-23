using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie.Models.DB;
using Movie.Repository;

namespace Movie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        public MovieController(ILogger<MovieController> logger)
        {
            this._logger = logger;
        }

        [HttpGet("GetMovie/{movieId}")]
        public IActionResult GetMovie(int movieId)
        {
            using (UnitOfWork UoW = new UnitOfWork())
            {
                Movie.Models.DB.Movie movie = UoW.MovieRepo.GetById(movieId);

                if (movie == null)
                {
                    _logger.LogInformation("Movie with Id: {movie} not found", movieId);
                    return NotFound("Movie not found");
                }
                return Ok(movie);
            }
        }

        [HttpGet("GetMoviesByGenre/{genreId}")]
        public IActionResult GetMoviesByGenre(int genreId)
        {
            using (UnitOfWork UoW = new UnitOfWork())
            {
                IEnumerable<Movie.Models.DB.Movie> movies = UoW.MovieRepo.GetMoviesByGenreId(genreId);

                if (movies.Count() == 0)
                {
                    _logger.LogInformation("Genre with Id: {genre} not found", genreId);
                    return NotFound("Genre not found");
                }
                return Ok(movies);
            }
        }

        [HttpGet("GetMoviesByActor/{actorId}")]
        public IActionResult GetMoviesByActor(int actorId)
        {
            using (UnitOfWork UoW = new UnitOfWork())
            {
                Actor actor = UoW.ActorRepo.GetById(actorId);

                if (actor == null)
                {
                    _logger.LogInformation("Actor with Id: {actor} not found", actorId);
                    return NotFound("Actor not found");
                }
                return Ok(actor);
            }
        }
    }
}
