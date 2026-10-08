using Microsoft.AspNetCore.Mvc;
using MVC031.Helpers;
using MVC031.Models;

namespace MVC031.Controllers
{
    public class CartController : Controller
    {
        public const string CartSessionKey = "Cart";

        private List<CartItem> GetCart()
        {
            return HttpContext.Session.GetObject<List<CartItem>>(CartSessionKey) ?? new List<CartItem>();
        }

        private void SaveCart(List<CartItem> cart)
        {
            HttpContext.Session.SetObject(CartSessionKey, cart);
        }

        // Xem giỏ hàng
        public IActionResult Index()
        {
            return View(GetCart());
        }

        // Thêm mặt hàng vào giỏ hàng (gọi bằng AJAX)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToCart(int id, int quantity = 1)
        {
            var product = ProductModel.GetProducts().FirstOrDefault(p => p.ProductID == id);
            if (product == null)
            {
                return NotFound(new { success = false, message = "Không tìm thấy sản phẩm" });
            }
            if (quantity < 1)
            {
                quantity = 1;
            }

            var cart = GetCart();
            var item = cart.FirstOrDefault(c => c.ProductID == id);
            if (item == null)
            {
                cart.Add(new CartItem
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    ImageURL = product.ImageURL,
                    ProductPrice = product.ProductPrice,
                    Quantity = quantity
                });
            }
            else
            {
                item.Quantity += quantity;
            }
            SaveCart(cart);

            return Json(new
            {
                success = true,
                message = $"Đã thêm \"{product.ProductName}\" vào giỏ hàng",
                cartCount = cart.Sum(c => c.Quantity),
                cartTotal = cart.Sum(c => c.Total)
            });
        }
    }
}
