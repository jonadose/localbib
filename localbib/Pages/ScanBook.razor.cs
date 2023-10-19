using Application.Features.OpenLib.Queries;
using MediatR;
using Microsoft.AspNetCore.Components;

namespace localbib.Pages
{
    public partial class ScanBook
    {
        [Inject]
        public required IMediator Mediator { get; set; }

        public string Input { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
        private bool _processing = false;

        public async Task SearchBook()
        {
            _processing = true;
            Result = await Mediator.Send(new GetBookByIsdnQuery { Isdn = Input });
            await Task.Delay(1000);
            _processing = false;
        }
    }
}
