namespace chain_of_responsibility.Models
{
  public class CartItem
  {
    public CartItem(double value)
    {
      Value = value;
    }
    public double Value { get; set; }
  }
}
