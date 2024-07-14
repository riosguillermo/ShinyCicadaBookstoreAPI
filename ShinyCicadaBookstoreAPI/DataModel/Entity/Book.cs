using System;
using System.Collections.Generic;

namespace ShinyCicadaBookstoreAPI.DataModel.Entity;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string? Synopsis { get; set; }

    public DateOnly? PublicationDate { get; set; }

    public string? Isbn { get; set; }

    public decimal Price { get; set; }

    public int StockQuantity { get; set; }

    public int? PublisherId { get; set; }

    public int? FormatId { get; set; }

    public int? LanguageId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual BookFormat? Format { get; set; }

    public virtual BookLanguage? Language { get; set; }

    public virtual Publisher? Publisher { get; set; }

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<SaleOrderItem> SaleOrderItems { get; set; } = new List<SaleOrderItem>();

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
