namespace Application.Contracts.Persistence
{
    public interface IUnitOfWork
    {
        public IBookRepository BookRepository { get; }
    }
}
