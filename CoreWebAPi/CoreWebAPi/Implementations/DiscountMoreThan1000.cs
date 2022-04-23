using CoreWebAPi.Interfaces;
using CoreWebAPi.Models;

namespace CoreWebAPi.Implementations
{
  public class DiscountMoreThan1000 : IDiscount
  {
    public double Calculate(Cart cart)
    {
      if (cart.TotalValue() > 1000)
        return (double)cart.TotalValue() * 0.3;

      return 0;
    }
  }
}
