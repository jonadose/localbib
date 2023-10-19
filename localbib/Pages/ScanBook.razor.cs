using MediatR;
using Microsoft.AspNetCore.Components;

namespace localbib.Pages
{
    public partial class ScanBook
    {
        [Inject]
        public required IMediator Mediator { get; set; }

        public string Input { get; set; } = string.Empty;
        private bool _processing = false;

        public async Task SearchBook()
        {
            _processing = true;
            await Task.Delay(1000);
            _processing = false;
        }
    }
}
