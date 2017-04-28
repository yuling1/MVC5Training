using SportsStore.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Service.Interface
{
    public interface IProductService
    {
        IEnumerable<Product> Products { get; }
    }
}
