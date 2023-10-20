using Application.Features.OpenLib.Models;
using MediatR;

namespace Application.Features.OpenLib.Queries.GetBookByIsdn
{
    public class GetBookByIsdnQuery : IRequest<OpenLibraryBook>
    {
        public required string Isdn { get; set; }
    }
}
