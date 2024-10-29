using Infrastructure.Interface;
using Infrastructure.Model;

namespace Infrastructure
{
    public class ProductRepo : IProductRepo
    {
        /// <summary>
        /// Lấy chi tiết sản phẩm
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductEntity GetById(Guid id)
        {
            var productDetail = new ProductEntity
            {
                product_id = Guid.NewGuid(),
                product_name = "ALL WHEEL BRIGHTENER",
                product_description = "A high-end smartphone with a stunning display.",
                product_original_price = 699.99m,
                product_sale_price = 649.99m,
                imageUrl = "/src/assets/productList/product-list-0.jpg"
            };
            return productDetail;
        }
        /// <summary>
        /// Lấy danh sách sản phẩm
        /// </summary>
        /// <returns></returns>
        public List<ProductEntity> GetPaging()
        {
            var products = new List<ProductEntity>
            {
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "ALL WHEEL BRIGHTENER",
                    product_description = "A high-end smartphone with a stunning display.",
                    product_original_price = 699.99m,
                    product_sale_price = 649.99m,
                    imageUrl = "/src/assets/productList/product-list-0.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "CERAMIX LIQUID WAX",
                    product_description = "Noise-canceling wireless headphones with crystal clear sound.",
                    product_original_price = 199.99m,
                    product_sale_price = 149.99m,
                    imageUrl = "/src/assets/productList/product-list-1.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "CHAI XỊT VỆ SINH NHỰA",
                    product_description = "A powerful laptop for gaming with a fast processor and graphics card.",
                    product_original_price = 1299.99m,
                    product_sale_price = 1149.99m,
                    imageUrl = "/src/assets/productList/product-list-2.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "DA FOAM CUTTING DISC",
                    product_description = "Portable Bluetooth speaker with deep bass and long battery life.",
                    product_original_price = 89.99m,
                    product_sale_price = 69.99m,
                    imageUrl = "/src/assets/productList/product-list-3.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "DUNG DỊCH LÀM SẠCH",
                    product_description = "Stylish smartwatch with multiple health tracking features.",
                    product_original_price = 249.99m,
                    product_sale_price = 199.99m,
                    imageUrl = "/src/assets/favoriteItems/favorite-item-4.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "DUNG DỊCH LÀM SẠCH",
                    product_description = "Large 4K LED TV with smart features and vibrant colors.",
                    product_original_price = 899.99m,
                    product_sale_price = 799.99m,
                    imageUrl = "/src/assets/favoriteItems/favorite-item-5.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "DUNG DỊCH RỬA XE HYPER",
                    product_description = "Ergonomic wireless mouse with adjustable DPI settings.",
                    product_original_price = 29.99m,
                    product_sale_price = 19.99m,
                    imageUrl = "/src/assets/favoriteItems/favorite-item-6.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "DUNG DỊCH ĐA NĂNG",
                    product_description = "RGB mechanical keyboard with programmable keys.",
                    product_original_price = 99.99m,
                    product_sale_price = 79.99m,
                    imageUrl = "/src/assets/favoriteItems/favorite-item-7.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "Fitness Tracker",
                    product_description = "Fitness tracker with heart rate monitor and GPS.",
                    product_original_price = 59.99m,
                    product_sale_price = 49.99m,
                    imageUrl = "https://example.com/images/fitness_tracker.jpg"
                },
                new ProductEntity()
                {
                    product_id = Guid.NewGuid(),
                    product_name = "Portable Charger",
                    product_description = "High capacity portable charger for all your devices.",
                    product_original_price = 39.99m,
                    product_sale_price = 29.99m,
                    imageUrl = "https://example.com/images/portable_charger.jpg"
                }
            };
            return products;
        }
    }
}
