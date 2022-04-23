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
    public void Should_Return_101_When_1000_Discount()
    {
      Cart cart = new Cart();

      cart.Items.Add(new CartItem(100));
      cart.Items.Add(new CartItem(600));
      cart.Items.Add(new CartItem(301));
      cart.Discount = DiscountChain();

      Assert.Equal(10.01, cart.Discount.Calculate(cart));
    }

    [Fact]
    public void Should_Return_416501_When_3000_Discount()
    {
      Cart cart = new Cart();

      cart.Items.Add(new CartItem(10000));
      cart.Items.Add(new CartItem(60000));
      cart.Items.Add(new CartItem(355501));
      cart.Discount = DiscountChain();

      Assert.Equal(4255.01, cart.Discount.Calculate(cart));
    }

    private IDiscount DiscountChain()
    {
      IDiscount discountMoreThan1000 = new DiscountForTotalMoreThan1000();
      IDiscount discountMoreThan2000 = new DiscountForTotalMoreThan2000();
      IDiscount discountMoreThan3000 = new DiscountForTotalMoreThan3000();

      discountMoreThan1000.Next = discountMoreThan2000;
      discountMoreThan2000.Next = discountMoreThan3000;
      discountMoreThan3000.Next = new NoDiscount();

      return discountMoreThan1000;
    }
  }
}


