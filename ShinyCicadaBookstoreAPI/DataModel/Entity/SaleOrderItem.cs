using System;
using System.Collections.Generic;

namespace ShinyCicadaBookstoreAPI.DataModel.Entity;

public partial class SaleOrderItem
{
    public int SaleOrderItemId { get; set; }

    public int? SaleOrderId { get; set; }

    public int? BookId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual Book? Book { get; set; }

    public virtual SaleOrder? SaleOrder { get; set; }
}
