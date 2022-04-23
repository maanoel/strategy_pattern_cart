namespace CoreWebAPi.Models
{
  public class CartItem
  {
    public CartItem(decimal value)
    {
      Value = value;
    }

    public decimal Value { get; set; }
  }
}
