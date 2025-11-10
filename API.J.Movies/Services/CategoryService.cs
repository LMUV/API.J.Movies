using API.J.Movies.DAL.Models;
using API.J.Movies.DAL.Models.Dtos;
using API.J.Movies.Repository.IRepository;
using API.J.Movies.Services.IServices;
using AutoMapper;

namespace API.J.Movies.Services

{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;


        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;   
        }

        public Task<bool> CategoryExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CategoryExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<CategoryDto> GetCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ICollection<CategoryDto>> GetCategoriesAsync()
        {
            var categories = _categoryRepository.GetCategoriesAsync();// solo estoy llamdo al metodo desde la capa de repositorio
            return _mapper.Map<ICollection<CategoryDto>>(categories); // mapeo de Category a CategoryDto 

        }


        public Task<bool> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
