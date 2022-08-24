namespace BlarozEcommerce.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        event Action Onchange;
        List<Category> Categories { get; set; }
        List<Category> AdminCategories { get; set; }
        Task GetCategories();
        Task<ServiceResponse<Category>> GetCategory(int categoryId);
        Task GetAdminCategories();
        Task AddCategory(Category category);
        Task UpdateCategory(Category category);
        Task DeleteCategory(int categoryId);
        Category CreateNewCategory();
    }
}
