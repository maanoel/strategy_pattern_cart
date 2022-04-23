using chain_of_responsibility.Interfaces;
using chain_of_responsibility.Models;

namespace chain_of_responsibility.Implementations
{
  public class DiscountForTotalMoreThan1000 : IDiscount
  {
    public IDiscount Next { get; set; }

    public double Calculate(Cart cart)
    {
      if (cart.Total > 1000)
      {
        return cart.Total * 0.01;
      }

      return Next.Calculate(cart);
    }
  }
}
