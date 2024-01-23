using Microsoft.EntityFrameworkCore;
using Movie.Models.DB;

namespace Movie.Repository
{
    public class ReviewRepository : IReviewRepository, IDisposable
    {
        private MovieContext context;

        public ReviewRepository(MovieContext context)
        {
            this.context = context;
        }

        public void Add(Review entity)
        {
            context.Reviews.Add(entity);
        }

        public void Delete(Review entity)
        {
            context.Reviews.Remove(entity);
        }

        public void Update(Review entity)
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
