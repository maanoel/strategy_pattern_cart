using CoreWebAPi.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CoreWebAPi.Models
{
  public class Cart
  {
    public List<CartItem> CartItems { get; set; }
    public IDiscount Discount { get; set; }

    public Cart()
    {
      CartItems = new List<CartItem>();
    }

    public decimal TotalValue()
    {
      return CartItems.Select(x => x.Value).Sum();
    }
  }
}
