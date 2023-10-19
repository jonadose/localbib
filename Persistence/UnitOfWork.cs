using Application.Contracts.Persistence;

namespace Persistence
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private bool _disposed = false;
        private readonly DataContext _dbContext;

        public IBookRepository BookRepository { get; private set; }

        public UnitOfWork(DataContext dbContext,
            IBookRepository bookRepository)
        {
            _dbContext = dbContext;
            BookRepository = bookRepository;
        }

        public async Task CompleteAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
