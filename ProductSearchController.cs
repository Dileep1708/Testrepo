using Microsoft.AspNetCore.Mvc;
using ProductSearch.Services;

namespace ProductSearch.Controllers
{
    public class ProductSearchController : Controller
    {
        private readonly IProductSearchService _productSearchService;

        public ProductSearchController(IProductSearchService productSearchService)
        {
            _productSearchService = productSearchService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string model, string name, string description, string manufacturer, string attributes)
        {            var products = _productSearchService.GetProductDetails(model, name, description, manufacturer, attributes);
            return View(products);
        }
    }
}

