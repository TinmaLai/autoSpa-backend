using Application.Interface;
using Infrastructure.Interface;
using Infrastructure.Model;

namespace Application
{
    public class ProductService : IProductService
    {
        private IProductRepo _repo;
        public ProductService(IProductRepo repo)
        {
            _repo = repo;
        }
        /// <summary>
        /// Lấy chi tiết sản phẩm
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public ProductEntity GetById(Guid id)
        {
            var product = _repo.GetById(id);
            return product;
        }

        /// <summary>
        /// Lấy danh sách sản phẩm theo paging
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<ProductEntity> GetPaging()
        {
           var products = _repo.GetPaging();
            return products;
        }
    }
}
