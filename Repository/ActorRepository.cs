using Microsoft.EntityFrameworkCore;
using Movie.Models.DB;

namespace Movie.Repository
{
    public class ActorRepository : IActorRepository, IDisposable
    {
        private MovieContext context;

        public ActorRepository(MovieContext context)
        {
            this.context = context;
        }

        public Actor GetById(int actorId)
        {
            return context.Actors
                .Include(x => x.Movies)
                .Where(x => x.Id == actorId).FirstOrDefault();
        }

        public IEnumerable<Actor> GetAll()
        {
            return context.Actors
             .Include(x => x.Movies);
        }

        public void Add(Actor entity)
        {
            context.Actors.Add(entity);
        }

        public void Delete(Actor entity)
        {
            context.Actors.Remove(entity);
        }

        public void Update(Actor entity)
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
