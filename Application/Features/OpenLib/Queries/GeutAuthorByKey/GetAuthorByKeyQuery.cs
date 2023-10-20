using Application.Features.OpenLib.Models;
using MediatR;

namespace Application.Features.OpenLib.Queries.GeutAuthorByKey
{
    public class GetAuthorByKeyQuery : IRequest<OpenLibraryAuthor>
    {
        public string Key { get; set; } = string.Empty;
    }
}
