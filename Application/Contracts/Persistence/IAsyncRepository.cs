using System.Linq.Expressions;

namespace Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllListAsync();
        Task<IReadOnlyList<T>> Find(Expression<Func<T, bool>> predicate);
        Task<T> AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Attach(T entity);
    }
}