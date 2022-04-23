using chain_of_responsibility.Models;

namespace chain_of_responsibility.Interfaces
{
  public interface IDiscount
  {
    public IDiscount Next { get; set; }
    public double Calculate(Cart cart);
  }
}
