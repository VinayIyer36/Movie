using Microsoft.EntityFrameworkCore;
using Movie.Models.DB;

namespace Movie.Repository
{
    public class MovieRepository : IMovieRepository, IDisposable
    {
        private MovieContext context;

        public MovieRepository(MovieContext context)
        {
            this.context = context;
        }

        public Movie.Models.DB.Movie GetById(int movieId)
        {
            return context.Movies
                .Where(x => x.Id == movieId).FirstOrDefault();
        }

        public IEnumerable<Movie.Models.DB.Movie> GetMoviesByGenreId(int genreId)
        {
            return context.Movies
                .Where(x => x.GenreMovies.Any(y => y.GenreId == genreId));
        }

        public IEnumerable<Movie.Models.DB.Movie> GetMoviesByActorId(int actorId)
        {
            return context.Movies
                .Where(x => x.ActorMovies.Any(y => y.ActorId == actorId));
        }

        public void Add(Movie.Models.DB.Movie entity)
        {
            context.Movies.Add(entity);
        }

        public void Delete(Movie.Models.DB.Movie entity)
        {
            context.Movies.Remove(entity);
        }

        public void Update(Movie.Models.DB.Movie entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~CapitalAllocationRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }


        #endregion
    }
}
