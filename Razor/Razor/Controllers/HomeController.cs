/*
 */

namespace Razor.Controllers
{
    using Razor.Models;
    using System.Web.Mvc;

    /// <summary>
    /// Home Controller类
    /// </summary>
    public class HomeController : Controller
    {
        // Mock一个Product实例做Demo
        Product myProduct = new Product()
        {
            ProductID = 1,
            Name = "Kayak",
            Description = "A boat for one person",
            Category = "Watersports",
            Price = 275M
        };

        /// <summary>
        /// Index Action，默认布局
        /// </summary>
        /// <returns>进入Index视图</returns>
        public ActionResult Index()
        {
            return View(myProduct);
        }

        /// <summary>
        /// BasicLayout Index Action，指定布局
        /// </summary>
        /// <returns></returns>
        public ActionResult BasicLayoutIndex()
        {
            return View(myProduct);
        }

        /// <summary>
        /// Name And Price Action，共享布局
        /// </summary>
        /// <returns></returns>
        public ActionResult NameAndPrice()
        {
            return View(myProduct);
        }

        /// <summary>
        /// 插入值，设置标签属性，使用条件表达式
        /// </summary>
        /// <returns></returns>
        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(myProduct);
        }

        /// <summary>
        /// 枚举数组和集合，处理命名空间
        /// </summary>
        /// <returns></returns>
        public ActionResult DemoArray()
        {
            Product[] array =
            {
                new Product {Name = "Kayak", Price = 275M },
                new Product {Name = "Lifejacket", Price = 48.95M },
                new Product {Name = "Soccer ball", Price = 19.50M },
                new Product {Name = "Corner flag", Price = 34.95M }
            };

            return View(array);
        }
    }
}