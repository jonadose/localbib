using Application.Features.OpenLib.Models;
using System.Threading.Tasks;

namespace Application.Contracts.Infrastructure
{
    public interface IOpenLibraryService
    {
        Task<OpenLibraryBook> GetBookByIsbnAsync(string isbn);
        Task<OpenLibraryAuthor> GetAuthorByKey(string key);
    }
}
