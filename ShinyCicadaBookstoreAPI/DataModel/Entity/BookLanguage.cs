using System;
using System.Collections.Generic;

namespace ShinyCicadaBookstoreAPI.DataModel.Entity;

public partial class BookLanguage
{
    public int BookLanguageId { get; set; }

    public string BookLanguageName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
