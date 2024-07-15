using System.Net;

namespace ShinyCicadaBookstoreAPI.DataModel.DTOs
{
    public class ResponseDto<T>
    {
        public HttpStatusCode Status { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }
    }
}
