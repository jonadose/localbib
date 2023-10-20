using Application.Contracts.Infrastructure;
using Application.Features.OpenLib.Models;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.OpenLib.Queries.GetBookByIsdn
{
    public class GetBookByIsdnQueryHandler : IRequestHandler<GetBookByIsdnQuery, OpenLibraryBook>
    {
        private readonly IOpenLibraryService _openLibraryService;
        private readonly ILogger<GetBookByIsdnQueryHandler> _logger;

        public GetBookByIsdnQueryHandler(
            IOpenLibraryService openLibraryService,
            ILogger<GetBookByIsdnQueryHandler> logger)
        {
            _openLibraryService = openLibraryService;
            _logger = logger;
        }

        public Task<OpenLibraryBook> Handle(GetBookByIsdnQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("{name} received request {request}.", nameof(GetBookByIsdnQueryHandler), request.ToString());
            return _openLibraryService.GetBookByIsbnAsync(request.Isdn);
        }
    }
}
