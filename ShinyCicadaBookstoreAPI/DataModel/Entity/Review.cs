using System;
using System.Collections.Generic;

namespace ShinyCicadaBookstoreAPI.DataModel.Entity;

public partial class Review
{
    public int ReviewId { get; set; }

    public int? BookId { get; set; }

    public int? PersonId { get; set; }

    public bool? Recommends { get; set; }

    public string? Comment { get; set; }

    public DateTime? ReviewDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual Book? Book { get; set; }

    public virtual Person? Person { get; set; }
}
