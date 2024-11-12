using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Model
{
    public class ProductEntity
    {
        /// <summary>
        /// Khóa sản phẩm
        /// </summary>
        public Guid product_id { get; set; }
        /// <summary>
        /// Tên sản phẩm
        /// </summary>
        public string? product_name { get; set; }
        /// <summary>
        /// Mô tả sản phẩm
        /// </summary>
        public string? product_description { get; set; }
        /// <summary>
        /// Giá gốc
        /// </summary>
        public int? product_original_price { get; set; }
        /// <summary>
        /// Giá giảm giá
        /// </summary>
        public int? product_sale_price { get; set; }
        /// <summary>
        /// Đường dẫn hình ảnh chung
        /// </summary>
        public string? imageUrl { get; set; }
    }
}
