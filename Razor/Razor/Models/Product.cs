/*
 */

namespace Razor.Models
{
    /// <summary>
    /// 产品类
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// 产品名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 产品价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 产品种类
        /// </summary>
        public string Category { get; set; }
    }
}