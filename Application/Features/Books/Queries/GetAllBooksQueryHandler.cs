using Application.Contracts.Persistence;
using Application.Features.Books.ViewModels;
using MediatR;

namespace Application.Features.Books.Queries
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookVm>>
    {
        public readonly IUnitOfWork _unitOfWork;

        public GetAllBooksQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<BookVm>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _unitOfWork.BookRepository.GetAllListAsync();
            return books.Select(book => book.ToVm()).ToList();

        }
    }
}
