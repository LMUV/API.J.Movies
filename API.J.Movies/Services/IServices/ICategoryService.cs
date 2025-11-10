using API.J.Movies.DAL.Models;
using API.J.Movies.DAL.Models.Dtos;

namespace API.J.Movies.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync(); // 

        Task<CategoryDto> GetCategoryAsync(int id); //  

        Task<bool> CategoryExistsByIdAsync(int id); // 

        Task<bool> CategoryExistsByNameAsync(string name); // 

        Task<bool> CreateCategoryAsync(Category category); //

        Task<bool> UpdateCategoryAsync(Category category); // n

        Task<bool> DeleteCategoryAsync(int id);
    }
} // 
