using Movie.Models.DB;

namespace Movie.Repository
{
    public class UnitOfWork : IDisposable
    {

        private MovieContext context = new MovieContext();

        private MovieRepository movieRepo;
        public MovieRepository MovieRepo
        {
            get
            {
                if (this.movieRepo == null)
                {
                    this.movieRepo = new MovieRepository(context);
                }
                return movieRepo;
            }
        }

        private ActorRepository actorRepo;
        public ActorRepository ActorRepo
        {
            get
            {
                if (this.actorRepo == null)
                {
                    this.actorRepo = new ActorRepository(context);
                }
                return actorRepo;
            }
        }

        private DirectorRepository directorRepo;
        public DirectorRepository DirectorRepo
        {
            get
            {
                if (this.directorRepo == null)
                {
                    this.directorRepo = new DirectorRepository(context);
                }
                return directorRepo;
            }
        }

        private GenreRepository genreRepo;
        public GenreRepository GenreRepo
        {
            get
            {
                if (this.genreRepo == null)
                {
                    this.genreRepo = new GenreRepository(context);
                }
                return genreRepo;
            }
        }

        private ReviewRepository reviewRepo;
        public ReviewRepository ReviewRepo
        {
            get
            {
                if (this.reviewRepo == null)
                {
                    this.reviewRepo = new ReviewRepository(context);
                }
                return reviewRepo;
            }
        }


        private AwardRepository awardRepo;
        public AwardRepository AwardRepo
        {
            get
            {
                if (this.awardRepo == null)
                {
                    this.awardRepo = new AwardRepository(context);
                }
                return awardRepo;
            }
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
        // ~UnitOfWork() {
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
