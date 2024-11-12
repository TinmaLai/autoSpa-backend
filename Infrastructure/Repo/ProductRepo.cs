using Infrastructure.Interface;
using Infrastructure.Model;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Infrastructure
{
    public class ProductRepo : IProductRepo
    {
        private readonly IConfiguration _configuration;
        public ProductRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }
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
                product_original_price = 69999,
                product_sale_price = 64999,
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
            var products = new List<ProductEntity>();
            string connectionString = _configuration.GetConnectionString("MySqlConnection");
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM products";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products.Add(new ProductEntity()
                                {
                                    product_id = reader.GetGuid("product_id"),
                                    product_name = reader.GetString("product_name"),
                                    product_description = reader.GetString("product_description"),
                                    product_original_price = reader.GetInt32("product_original_price"),
                                    product_sale_price = reader.GetInt32("product_sale_price"),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thực hiện truy vấn: " + ex.Message);
            }

            return products;
        }
    }
}
