using ShinyCicadaBookstoreAPI.DataModel.DTOs;
using ShinyCicadaBookstoreAPI.DataModel.DTOs.Book;

namespace ShinyCicadaBookstoreAPI.Services.Interfaces
{
    public interface IBookServices
    {
        Task<ResponseDto<GetBookResponseDto>> GetBookByID(int id);
    }
}
