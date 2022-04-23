using chain_of_responsibility.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace chain_of_responsibility.Models
{
  public class Cart
  {
    public IDiscount Discount { get; set; }
    public List<CartItem> Items { get; set; }

    public double Total
    {
      get
      {
        return Items.Select(x => x.Value).Sum();
      }
    }
  }
}
