using Movie.Models.DB;

namespace Movie.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }

    interface IMovieRepository : IRepository<Movie.Models.DB.Movie>, IDisposable { }

    interface IDirectorRepository : IRepository<Director>, IDisposable { }
    interface IActorRepository : IRepository<Actor>, IDisposable { }
    interface IGenreRepository : IRepository<Genre>, IDisposable { }
    interface IReviewRepository : IRepository<Review>, IDisposable { }
    interface IAwardRepository : IRepository<Award>, IDisposable { }
}
