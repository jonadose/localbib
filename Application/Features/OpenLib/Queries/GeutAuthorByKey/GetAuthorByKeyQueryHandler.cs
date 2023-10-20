using Application.Contracts.Infrastructure;
using Application.Features.OpenLib.Models;
using Application.Features.OpenLib.Queries.GetBookByIsdn;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.OpenLib.Queries.GeutAuthorByKey
{
    public class GetAuthorByKeyQueryHandler : IRequestHandler<GetAuthorByKeyQuery, OpenLibraryAuthor>
    {
        private readonly IOpenLibraryService _openLibraryService;
        private readonly ILogger<GetAuthorByKeyQueryHandler> _logger;

        public GetAuthorByKeyQueryHandler(
            IOpenLibraryService openLibraryService,
            ILogger<GetAuthorByKeyQueryHandler> logger)
        {
            _openLibraryService = openLibraryService;
            _logger = logger;
        }


        public Task<OpenLibraryAuthor> Handle(GetAuthorByKeyQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("{name} received request for author key: {key}.", nameof(GetAuthorByKeyQueryHandler), request.Key);
            return _openLibraryService.GetAuthorByKey(request.Key);
        }
    }
}
