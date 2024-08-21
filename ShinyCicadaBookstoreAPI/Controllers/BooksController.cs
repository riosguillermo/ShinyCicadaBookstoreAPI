using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShinyCicadaBookstoreAPI.DataModel.DTOs;
using ShinyCicadaBookstoreAPI.DataModel.DTOs.Book;
using ShinyCicadaBookstoreAPI.Services.Interfaces;

namespace ShinyCicadaBookstoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksServices _bookServices;

        public BooksController(IBooksServices bookServices)
        {
            _bookServices = bookServices;
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto<GetBookResponseDto>> GetBookByID(int id)
        {
            return await _bookServices.GetBookByID(id);
        }

        [HttpGet]
        public async Task<ResponseDto<IEnumerable<GetBookResponseDto>>> GetAllBooks()
        {
            return await _bookServices.GetAllBooks();
        }
    }
}
