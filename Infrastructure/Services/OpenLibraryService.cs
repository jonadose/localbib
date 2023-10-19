using Application.Contracts.Infrastructure;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace Infrastructure.Services
{
    public class OpenLibraryService : IOpenLibraryService, IDisposable
    {
        private readonly ILogger<OpenLibraryService> _logger;
        private readonly HttpClient _httpClient;


        public OpenLibraryService(ILogger<OpenLibraryService> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<string> GetBookByIsbnAsync(string isbn)
        {
            _logger.LogInformation($"Getting book with isbn {isbn}");
            var response = await _httpClient.GetAsync($"{isbn}.json");
            return await response.Content.ReadAsStringAsync();
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
