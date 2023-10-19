using Domain.Entities;

namespace Application.Features.Books.ViewModels
{
    public static class BookMapper
    {
        //Entity to ViewModel
        public static BookVm ToVm(this Book book)
        {
            return MapAllProperties(book, new BookVm());
        }


        private static BookVm MapAllProperties(Book book, BookVm bookVm)
        {
            bookVm.Id = book.Id;
            bookVm.Title = book.Title;
            bookVm.Author = book.Author;
            bookVm.Description = book.Description;
            bookVm.Isbn_10 = book.Isbn_10;
            bookVm.Isbn_13 = book.Isbn_13;
            bookVm.Rating = book.Rating;

            return bookVm;
        }
    }
}
