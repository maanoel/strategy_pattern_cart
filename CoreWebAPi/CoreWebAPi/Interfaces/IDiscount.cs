using CoreWebAPi.Models;

namespace CoreWebAPi.Interfaces
{
  public interface IDiscount
  {
    public double Calculate(Cart cart);
  }
}
