

namespace SportsStore.WebPortal.Controllers
{
    using SportsStore.Service.Interface;
    using System.Web.Mvc;
    using System.Linq;
    using Models;

    public class ProductController : Controller
    {
        private IProductService productService;

        public int PageSize = 4;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public ActionResult List()
        {
            return View(this.productService.Products);
        }

        // GET: Product
        public ActionResult PagedList(int page = 1)
        {
            var products = this.productService.Products
                .OrderBy(p => p.ProductID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize);

            var pagingInfo = new PagingInfo
            {
                CurrentPage = page,
                ItemsPerPage = PageSize,
                TotalItems = this.productService.Products.Count()
            };

            ProductListViewModel model = new ProductListViewModel
            {
                Products = products,
                PagingInfo = pagingInfo
            };

            return View(model);
        }
    }
}