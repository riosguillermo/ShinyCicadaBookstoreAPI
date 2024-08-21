using ShinyCicadaBookstoreAPI.DataModel.DTOs;
using ShinyCicadaBookstoreAPI.DataModel.DTOs.Book;

namespace ShinyCicadaBookstoreAPI.Services.Interfaces
{
    public interface IBooksServices
    {
        Task<ResponseDto<GetBookResponseDto>> GetBookByID(int id);

        Task<ResponseDto<IEnumerable<GetBookResponseDto>>> GetAllBooks();
    }
}
