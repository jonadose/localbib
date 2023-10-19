using MediatR;

namespace Application.Features.OpenLib.Queries
{
    public class GetBookByIsdnQuery : IRequest<string>
    {
        public required string Isdn { get; set; }
    }
}
