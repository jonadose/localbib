using Application.Contracts.Infrastructure;
using Application.Features.OpenLib.Models;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Text.Json;

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

        public async Task<OpenLibraryBook> GetBookByIsbnAsync(string isbn)
        {
            _logger.LogInformation($"Getting book with isbn {isbn}");
            var response = await _httpClient.GetAsync($"isbn/{isbn}.json");
            var content = await response.Content.ReadAsStringAsync();
            if (content is null || response.StatusCode == HttpStatusCode.NotFound)
            {
                _logger.LogInformation($"Book with isbn {isbn} not found");
                return null;
            }

            JsonSerializerOptions options = new()
            {
                PropertyNameCaseInsensitive = true,
            };

            ArgumentNullException.ThrowIfNull(content);
            OpenLibraryBook? responseBook = JsonSerializer.Deserialize<OpenLibraryBook>(content, options);

            if (responseBook is null)
            {
                return null;
            }
            return responseBook;
        }


        public async Task<OpenLibraryAuthor> GetAuthorByKey(string key)
        {
            _logger.LogInformation($"Getting author with key {key}");
            var response = await _httpClient.GetAsync($"{key}.json");
            var content = await response.Content.ReadAsStringAsync();
            if (content is null || response.StatusCode == HttpStatusCode.NotFound)
            {
                _logger.LogInformation($"Author with key {key} not found");
                return null;
            }

            JsonSerializerOptions options = new()
            {
                PropertyNameCaseInsensitive = true,
            };
            ArgumentNullException.ThrowIfNull(content);
            OpenLibraryAuthor? responseAuthor = JsonSerializer.Deserialize<OpenLibraryAuthor>(content, options);

            if (responseAuthor is null)
            {
                return null;
            }
            return responseAuthor;

        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
