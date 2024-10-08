﻿using ShinyCicadaBookstoreAPI.DataModel.DTOs;
using ShinyCicadaBookstoreAPI.DataModel.DTOs.Book;
using ShinyCicadaBookstoreAPI.DataModel.Entity;
using ShinyCicadaBookstoreAPI.Services.Interfaces;

namespace ShinyCicadaBookstoreAPI.Services.Implementation
{
    public class BooksServices : IBooksServices
    {
        private readonly ShinyCicadaBookstoreDatabaseContext _dbContext;

        public BooksServices(ShinyCicadaBookstoreDatabaseContext dbContext)
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
                    ID = book.BookId,
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

        public async Task<ResponseDto<IEnumerable<GetBookResponseDto>>> GetAllBooks()
        {
            var BookList = _dbContext.Books.ToList();
            var res = new List<GetBookResponseDto>();

            foreach (var book in BookList)
            {
                res.Add(new GetBookResponseDto()
                {
                    ID = book.BookId,
                    Title = book.Title,
                    Synopsis = book.Synopsis,
                    PublicationDate = book.PublicationDate,
                    ISBN = book.Isbn,
                    StockQuantity = book.StockQuantity,
                    PublisherId = book.PublisherId,
                    FormatId = book.FormatId,
                    LanguageId = book.LanguageId
                });
            }

            return new ResponseDto<IEnumerable<GetBookResponseDto>>
            {
                Status = System.Net.HttpStatusCode.OK,
                Message = "Full Books list",
                Data = res
            };
        }
    }
}
