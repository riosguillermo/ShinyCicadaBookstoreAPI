using System;
using System.Collections.Generic;

namespace ShinyCicadaBookstoreAPI.DataModel.Entity;

public partial class SaleOrder
{
    public int SaleOrderId { get; set; }

    public int? PersonId { get; set; }

    public DateTime SaleOrderDate { get; set; }

    public decimal TotalAmount { get; set; }

    public int? StatusId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual Person? Person { get; set; }

    public virtual ICollection<SaleOrderItem> SaleOrderItems { get; set; } = new List<SaleOrderItem>();

    public virtual OrderStatus? Status { get; set; }
}
