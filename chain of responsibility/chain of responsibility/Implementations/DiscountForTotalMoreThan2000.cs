using chain_of_responsibility.Interfaces;
using chain_of_responsibility.Models;

namespace chain_of_responsibility.Implementations
{
  public class DiscountForTotalMoreThan2000 : IDiscount
  {
    public IDiscount Next { get; set; }

    public double Calculate(Cart cart)
    {
      if (cart.Total > 2000)
      {
        return cart.Total * 0.02;
      }

      return Next.Calculate(cart);
    }
  }
}
