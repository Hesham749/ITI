using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using static WebApplication1.Models.ProductBL;
namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAll()
        {
            List<Product> products = [.. GetAllProducts()];
            return View("AllProducts", products);
        }

        public IActionResult ProductDetails(int id)
            =>
             View("ProductDetails", GetProduct(id));
    }
}
