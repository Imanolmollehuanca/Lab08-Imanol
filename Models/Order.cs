using System;
using System.Collections.Generic;

namespace Lab08_Imanol.Models;

public partial class Order
{
    public int Orderid { get; set; }

    public int ClientId { get; set; }

    public DateTime OrderDate { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<Orderdetail> Orderdetails { get; set; } = new List<Orderdetail>();

}