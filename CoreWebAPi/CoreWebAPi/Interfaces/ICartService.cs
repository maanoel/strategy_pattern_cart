using CoreWebAPi.Models;

namespace CoreWebAPi.Interfaces
{
  public interface ICartService
  {
    double CalculateCartDiscount(Cart cart);
  }
}
