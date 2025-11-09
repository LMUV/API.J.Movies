using API.J.Movies.DAL;
using API.J.Movies.DAL.Models;
using API.J.Movies.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;


namespace API.J.Movies.Repository
{
    public class CategoryRepository : ICategoryRepository
    {   
        private readonly ApplicationDbContext _contex;
        public CategoryRepository(ApplicationDbContext contex)
        {
            _contex = contex;
        }

        
        public  async Task<bool> CategoryExistsByIdAsync(int id)
        {
            return await _contex.Categories
             .AsNoTracking() // para mejorar el perfonmace de la consulta 
             .AnyAsync(c => c.Id == id); // lambda expresione
             
        }

        public async Task<bool> CategoryExistsByNameAsync(string name)
        {
               return await _contex.Categories
                      .AsNoTracking() // para mejorar el perfonmace de la consulta 
                      .AnyAsync(c => c.Name == name); // lambda expresione
        }

        public async Task<bool> CreateCategoryAsync(Category category)
        {
            category.CreatedDate = DateTime.UtcNow;
            await _contex.Categories.AddAsync(category);
            return await SaveAsync();
            //SQL INSERT

        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var category = await GetCategoryAsync(id) ; //primero consulto que si exista la categoria
            
            if (category == null)
            {   
                return false; // si no existe retorno false              
            }
            
            _contex.Categories.Remove(category); // si existe la elimino
            return await SaveAsync();
        }

        public async Task<ICollection<Category>> GetCategoriesAsync()
        {
            return await _contex.Categories
                    .AsNoTracking()
                    .OrderBy(c => c.Name) // ordeno por nombre
                    .ToListAsync();
        }

        public async Task<Category> GetCategoryAsync(int id) // async y el await
        {
                return await _contex.Categories
                       .AsNoTracking()
                       .FirstOrDefaultAsync(c => c.Id == id); // lambda expresiones ---busco la categoria por su ID

        }

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            category.ModifiedDate = DateTime.UtcNow;
             _contex.Categories.Update(category);
            return await SaveAsync();
        }

        private async Task<bool> SaveAsync()
        {
            return await _contex.SaveChangesAsync() >= 0 ? true : false;
        }
    }


}
