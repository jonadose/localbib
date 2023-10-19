using Application.Features.Books.Queries;
using Application.Features.Books.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Components;

namespace localbib.Pages.Components
{
    public partial class BookTableComponent
    {

        [Inject]
        public required IMediator Mediator { get; set; }

        private List<BookVm> _books = new();

        protected override async Task OnInitializedAsync()
        {
            _books = await Mediator.Send(new GetAllBooksQuery());
        }
    }
}
