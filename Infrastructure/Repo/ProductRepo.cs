using Infrastructure.Interface;
using Infrastructure.Model;

namespace Infrastructure
{
    public class ProductRepo : IProductRepo
    {
        public List<ProductEntity> GetPaging()
        {
            var products = new List<ProductEntity>
            {
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "Smartphone X1",
                    product_description = "A high-end smartphone with a stunning display.",
                    product_original_price = 699.99m,
                    product_sale_price = 649.99m,
                    imageUrl = "https://example.com/images/smartphone_x1.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "Wireless Headphones",
                    product_description = "Noise-canceling wireless headphones with crystal clear sound.",
                    product_original_price = 199.99m,
                    product_sale_price = 149.99m,
                    imageUrl = "https://example.com/images/wireless_headphones.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "Gaming Laptop",
                    product_description = "A powerful laptop for gaming with a fast processor and graphics card.",
                    product_original_price = 1299.99m,
                    product_sale_price = 1149.99m,
                    imageUrl = "https://example.com/images/gaming_laptop.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "Bluetooth Speaker",
                    product_description = "Portable Bluetooth speaker with deep bass and long battery life.",
                    product_original_price = 89.99m,
                    product_sale_price = 69.99m,
                    imageUrl = "https://example.com/images/bluetooth_speaker.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "Smartwatch S2",
                    product_description = "Stylish smartwatch with multiple health tracking features.",
                    product_original_price = 249.99m,
                    product_sale_price = 199.99m,
                    imageUrl = "https://example.com/images/smartwatch_s2.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "4K LED TV",
                    product_description = "Large 4K LED TV with smart features and vibrant colors.",
                    product_original_price = 899.99m,
                    product_sale_price = 799.99m,
                    imageUrl = "https://example.com/images/4k_led_tv.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "Wireless Mouse",
                    product_description = "Ergonomic wireless mouse with adjustable DPI settings.",
                    product_original_price = 29.99m,
                    product_sale_price = 19.99m,
                    imageUrl = "https://example.com/images/wireless_mouse.jpg"
                },
                new ProductEntity
                {
                    product_id = Guid.NewGuid(),
                    product_name = "Mechanical Keyboard",
                    product_description = "RGB mechanical keyboard with programmable keys.",
                    product_original_price = 99.99m,
                    product_sale_price = 79.99m,
                    imageUrl = "https://example.com/images/mechanical_keyboard.jpg"
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
