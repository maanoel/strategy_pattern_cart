using CoreWebAPi.Implementations;
using CoreWebAPi.Interfaces;
using CoreWebAPi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebAPi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CartController : ControllerBase
  {
    private readonly ICartService _cartService;

    public CartController(ICartService cartService)
    {
      _cartService = cartService;
    }

    [HttpGet]
    public double CalculateCartDiscount()
    {
      Cart cart = new Cart();
      cart.CartItems.Add(new CartItem(100));
      cart.CartItems.Add(new CartItem(300));
      cart.CartItems.Add(new CartItem(400));
      cart.CartItems.Add(new CartItem(400));
      cart.CartItems.Add(new CartItem(1400));

      //cart.Discount = new DiscountValueMoreThan500();
      //cart.Discount = new DiscountMoreThan1000();
      cart.Discount = new DiscountMoreThan2000();

      return _cartService.CalculateCartDiscount(cart);
    }
  }
}

