using Application.Contracts.Persistence;
using Domain.Entities;

namespace Persistence.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(DataContext dbContext) : base(dbContext)
        {
        }
    }
}
