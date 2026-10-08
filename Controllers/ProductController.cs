using Microsoft.AspNetCore.Mvc;
using MVC031.Models;

namespace MVC031.Controllers
{
    public class ProductController : Controller
    {
      
        public IActionResult ProductList()
        {
            List<ProductModel> products = ProductModel.GetProducts();
            return View(products);
        }

       
        public IActionResult ProductDetail(int id)
        {
            var product = ProductModel.GetProducts()
                                       .FirstOrDefault(p => p.ProductID == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}