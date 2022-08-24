namespace BlarozEcommerce.Client.Services.ProductTypeService
{
    public interface IProductTypeService
    {
        event Action OnChange;
        public List<ProductType> ProductTypes { get; set; }
        Task GetProductTypes();
        Task<ServiceResponse<ProductType>> GetProductType(int productTypeId);
        Task AddProductType(ProductType productType);
        Task UpdateProductType(ProductType productType);
        Task DeleteProductType(int productTypeId);
        ProductType CreateNewProductType();
    }
}
