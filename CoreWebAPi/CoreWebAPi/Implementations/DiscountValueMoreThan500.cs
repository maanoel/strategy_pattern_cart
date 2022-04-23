using CoreWebAPi.Interfaces;
using CoreWebAPi.Models;
using System;

namespace CoreWebAPi.Implementations
{
  public class DiscountValueMoreThan500 : IDiscount
  {
    public double Calculate(Cart cart)
    {
      if (cart.TotalValue() > 500)
        return (double) cart.TotalValue() * 0.1;

      return 0;
    }
  }
}
