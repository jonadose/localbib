using Application.Features.OpenLib.Models;
using Application.Features.OpenLib.Queries;
using Application.Features.OpenLib.Queries.GetBookByIsdn;
using Application.Features.OpenLib.Queries.GeutAuthorByKey;
using MediatR;
using Microsoft.AspNetCore.Components;

namespace localbib.Pages
{
    public partial class ScanBook
    {
        [Inject]
        public required IMediator Mediator { get; set; }

        public string Input { get; set; } = string.Empty;
        public OpenLibraryBook? Result { get; set; }
        public List<OpenLibraryAuthor?> Authors { get; set; } = new();
        private bool _processing;
        private string _coverpath = string.Empty;


        public async Task SearchBook()
        {
            _processing = true;
            Result = await Mediator.Send(new GetBookByIsdnQuery { Isdn = Input });
            await GetAdditionalInfo();
            _processing = false;

        }


        private async Task GetAdditionalInfo()
        {
            if (Result is null)
            {
                return;
            }

            _coverpath = "https://covers.openlibrary.org/b/isbn/" + Result.Isbn13.First() + "-L.jpg";
            foreach (var author in Result.Authors)
            {
                Authors.Add(await Mediator.Send(new GetAuthorByKeyQuery { Key = author.Key }));
            }
        }


        public async Task AddBook()
        {
            _processing = true;
            await Task.Delay(1000);
            _processing = false;
            return;
        }
    }
}
