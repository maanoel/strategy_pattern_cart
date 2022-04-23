using CoreWebAPi.Interfaces;
using CoreWebAPi.Models;

namespace CoreWebAPi.Services
{
  public class CartService : ICartService
  {
    public double CalculateCartDiscount(Cart cart)
    {
      return cart.Discount.Calculate(cart);
    }
  }
}
