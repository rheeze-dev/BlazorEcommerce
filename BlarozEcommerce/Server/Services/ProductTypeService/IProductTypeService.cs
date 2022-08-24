namespace BlarozEcommerce.Server.Services.ProductTypeService
{
    public interface IProductTypeService
    {
        Task<ServiceResponse<List<ProductType>>> GetProductTypes();
        Task<ServiceResponse<ProductType>> GetProductTypeAsync(int productTypeId);
        Task<ServiceResponse<List<ProductType>>> AddProductType(ProductType productType);
        Task<ServiceResponse<List<ProductType>>> UpdateProductType(ProductType productType);
        Task<ServiceResponse<List<ProductType>>> DeleteProductType(int id);
    }
}
