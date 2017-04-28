using SportsStore.DB.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Service
{
    public class BaseService
    {
        protected EFDbContext context;

        public BaseService(EFDbContext _context)
        {
            this.context = _context;
        }
    }
}
