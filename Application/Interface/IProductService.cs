using Infrastructure.Model;

namespace Application.Interface
{
    public interface IProductService
    {
        /// <summary>
        /// Lấy danh sách sản phẩm
        /// </summary>
        /// <returns></returns>
        List<ProductEntity> GetPaging();

        /// <summary>
        /// Lấy chi tiết sản phẩm
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ProductEntity GetById(Guid id);
    }
}
