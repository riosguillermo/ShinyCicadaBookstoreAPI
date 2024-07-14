using System;
using System.Collections.Generic;

namespace ShinyCicadaBookstoreAPI.DataModel.Entity;

public partial class Author
{
    public int AuthorId { get; set; }

    public string AuthorName { get; set; } = null!;

    public string? AuthorBiography { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
