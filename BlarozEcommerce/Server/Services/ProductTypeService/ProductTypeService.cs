namespace BlarozEcommerce.Server.Services.ProductTypeService
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly DataContext _context;

        public ProductTypeService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<ProductType>>> AddProductType(ProductType productType)
        {
            productType.Editing = productType.IsNew = false;
            _context.ProductTypes.Add(productType);
            await _context.SaveChangesAsync();

            return await GetProductTypes();
        }

        public async Task<ServiceResponse<List<ProductType>>> GetProductTypes()
        {
            var productTypes = await _context.ProductTypes.ToListAsync();
            return new ServiceResponse<List<ProductType>> { Data = productTypes };
        }

        public async Task<ServiceResponse<List<ProductType>>> UpdateProductType(ProductType productType)
        {
            var dbProductType = await _context.ProductTypes.FindAsync(productType.Id);
            if (dbProductType == null)
            {
                return new ServiceResponse<List<ProductType>>
                {
                    Success = false,
                    Message = "Product type not found."
                };
            }

            dbProductType.Name = productType.Name;
            await _context.SaveChangesAsync();

            return await GetProductTypes();
        }

        public async Task<ServiceResponse<List<ProductType>>> DeleteProductType(int id)
        {
            ProductType productType = await GetProductTypeById(id);
            //if (productType == null)
            //{
            //    return new ServiceResponse<List<ProductType>>
            //    {
            //        Success = false,
            //        Message = "Product type not found."
            //    };
            //}
            _context.Remove(productType);
            //productType.Deleted = true;
            await _context.SaveChangesAsync();

            return await GetProductTypes();
        }

        private async Task<ProductType> GetProductTypeById(int id)
        {
            return await _context.ProductTypes.FirstOrDefaultAsync(pt => pt.Id == id);
        }

        public async Task<ServiceResponse<ProductType>> GetProductTypeAsync(int productTypeId)
        {
            var response = new ServiceResponse<ProductType>();
            ProductType productType = null;
            productType = await _context.ProductTypes.FirstOrDefaultAsync(c => c.Id == productTypeId);
            response.Data = productType;
            return response;
        }
    }
}
