using SportsStore.DB.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.DB.Context
{
    public class EFDbContext : DbContext
    {
        /// <summary>
        /// 指定EF的连接关键字并设置数据库初始化程序
        /// </summary>
        public EFDbContext() : base("name=EFDbCon")
        {
            Database.SetInitializer<EFDbContext>(new EFDBContextInitializer());
        }

        public DbSet<Product> Products { get; set; }
    }

    public class EFDBContextInitializer : CreateDatabaseIfNotExists<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            // 初始化数据库
            context.Products.AddRange(new List<Product> {
                    new Product { Name = "Football", Description = "Football description", Price = 25},
                    new Product { Name = "Stuff board", Description = "Stuff board description", Price = 179 },
                    new Product { Name = "Running shoes", Description = "Running shoes description", Price = 95 },
                    new Product { Name = "Basketball", Description = "Basketball description", Price = 125},
                    new Product { Name = "Volleyball", Description = "Volleyball description", Price = 59 },
                    new Product { Name = "Basketball shoes", Description = "Basketball shoes description", Price = 195 },
                    new Product { Name = "Volleyball shoes", Description = "Volleyball shoes description", Price = 205},
                    new Product { Name = "Swimming clothes", Description = "Swimming clothes description", Price = 199 },
                    new Product { Name = "Climbing boot", Description = "Climbing boot description", Price = 900 }
                });

            base.Seed(context);
        }
    }
}
