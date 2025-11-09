using API.J.Movies.DAL.Models;

namespace API.J.Movies.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task<ICollection<Category>> GetCategoriesAsync(); // ME retorna Una lista de CATEGORIAS

        Task<Category> GetCategoryAsync(int id); // ME retorna UNA CATEGORIA por su ID  

        Task<bool> CategoryExistsByIdAsync(int id); // ME retorna TRUE o FALSE si existe una CATEGORIA por su NOMBRE

        Task<bool> CategoryExistsByNameAsync(string name); // ME dice  si existe una CATEGORIA por su NOMBRE

        Task<bool> CreateCategoryAsync(Category category); // ME permite CREAR una CATEGORIA

        Task<bool> UpdateCategoryAsync(Category category); // ME  crea una categoria--puedo actualizar el nombre y la fecha de actualizacion

        Task<bool> DeleteCategoryAsync(int id); // ME permite ELIMINAR una CATEGORIA  
    }
}
