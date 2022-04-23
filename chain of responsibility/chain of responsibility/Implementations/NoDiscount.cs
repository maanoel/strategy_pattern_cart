using chain_of_responsibility.Interfaces;
using chain_of_responsibility.Models;

namespace chain_of_responsibility.Implementations
{
  public class NoDiscount : IDiscount
  {
    public IDiscount Next { get; set; }

    public double Calculate(Cart cart)
    {
      return 0;
    }
  }
}
