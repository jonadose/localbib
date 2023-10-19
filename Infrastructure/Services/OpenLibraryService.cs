using Application.Contracts.Infrastructure;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Services
{
    public class OpenLibraryService : IOpenLibraryService
    {
        private readonly ILogger<OpenLibraryService> _logger;

        public OpenLibraryService(ILogger<OpenLibraryService> logger)
        {
            _logger = logger;
        }

        public Task GetBookWithIsbn(string isbn)
        {
            _logger.LogInformation($"Getting book with isbn {isbn}");
            return Task.CompletedTask;
        }
    }
}
