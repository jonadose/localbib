namespace localbib.Pages
{
    public partial class ScanBook
    {
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
