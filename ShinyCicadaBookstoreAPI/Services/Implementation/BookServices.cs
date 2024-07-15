using ShinyCicadaBookstoreAPI.DataModel.DTOs;
using ShinyCicadaBookstoreAPI.DataModel.DTOs.Book;
using ShinyCicadaBookstoreAPI.DataModel.Entity;
using ShinyCicadaBookstoreAPI.Services.Interfaces;

namespace ShinyCicadaBookstoreAPI.Services.Implementation
{
    public class BookServices : IBookServices
    {
        private readonly ShinyCicadaBookstoreDatabaseContext _dbContext;

        public BookServices(ShinyCicadaBookstoreDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ResponseDto<GetBookResponseDto>> GetBookByID(int id)
        {
            Book? book = _dbContext.Books.FirstOrDefault(b => b.BookId == id);

            if (book != null)
            {
                var res = new GetBookResponseDto()
                {
                    BookId = book.BookId,
                    Title = book.Title,
                    Synopsis = book.Synopsis,
                    PublicationDate = book.PublicationDate,
                    ISBN = book.Isbn,
                    StockQuantity = book.StockQuantity,
                    PublisherId = book.PublisherId,
                    FormatId = book.FormatId,
                    LanguageId = book.LanguageId
                };


                return new ResponseDto<GetBookResponseDto>()
                {
                    Status = System.Net.HttpStatusCode.OK,
                    Message = "Book Found",
                    Data = res
                };
            }
            else
            {
                return new ResponseDto<GetBookResponseDto>()
                {
                    Status = System.Net.HttpStatusCode.NotFound,
                    Message = "Book not found",
                    Data = null
                };
            }
        }
    }
}
