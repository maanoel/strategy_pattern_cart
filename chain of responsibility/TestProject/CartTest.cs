using chain_of_responsibility.Implementations;
using chain_of_responsibility.Interfaces;
using chain_of_responsibility.Models;
using System.Collections.Generic;
using Xunit;

namespace TestProject
{
  public class CartTest
  {
    [Fact]
    public void Should_Return_100_When_Ten_Percent_Discount()
    {
      Cart cart = new Cart();

      cart.Items.Add(new CartItem(100));
      cart.Items.Add(new CartItem(600));
      cart.Items.Add(new CartItem(300));

      List<IDiscount> discount = new List<IDiscount>();

      discount.Add(new DiscountForTotalMoreThan1000());

      Assert.Equal(100, cart.Discount.Calculate(cart));
    }
  }
}
