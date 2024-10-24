using Infrastructure.Model;

namespace Application.Interface
{
    public interface IProductService
    {
        List<ProductEntity> GetPaging();
    }
}
