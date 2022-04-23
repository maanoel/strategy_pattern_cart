using CoreWebAPi.Interfaces;
using CoreWebAPi.Models;

namespace CoreWebAPi.Implementations
{
  public class DiscountMoreThan2000 : IDiscount
  {
    public double Calculate(Cart cart)
    {
      if (cart.TotalValue() > 2000)
        return (double)cart.TotalValue() * 0.5;

      return 0;
    }
  }
}
