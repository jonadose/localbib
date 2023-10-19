using Application.Features.Books.ViewModels;
using MediatR;

namespace Application.Features.Books.Queries
{
    public class GetAllBooksQuery : IRequest<List<BookVm>>
    {
    }
}
