namespace Application.Contracts.Infrastructure
{
    public interface IOpenLibraryService
    {
        Task GetBookWithIsbn(string isbn);
    }
}
