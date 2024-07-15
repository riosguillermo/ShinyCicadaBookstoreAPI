using ShinyCicadaBookstoreAPI.DataModel.Entity;

namespace ShinyCicadaBookstoreAPI.DataModel.DTOs.Book
{
    public class GetBookResponseDto
    {
        public int BookId { get; set; }

        public string Title { get; set; } = null!;

        public string? Synopsis { get; set; }

        public DateOnly? PublicationDate { get; set; }

        public string? ISBN { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public int? PublisherId { get; set; }

        public int? FormatId { get; set; }

        public int? LanguageId { get; set; }

    }
}
