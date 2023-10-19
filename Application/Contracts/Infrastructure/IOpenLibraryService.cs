namespace Application.Contracts.Infrastructure
{
    public interface IOpenLibraryService
    {
        Task<string> GetBookByIsbnAsync(string isbn);
    }
}
