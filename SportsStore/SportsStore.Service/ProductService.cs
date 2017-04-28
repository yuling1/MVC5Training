using SportsStore.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.DB.Entities;
using SportsStore.DB.Context;

namespace SportsStore.Service
{
    public class ProductService : BaseService, IProductService
    {
        public ProductService(EFDbContext context) : base(context)
        {
        }

        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }
    }
}
