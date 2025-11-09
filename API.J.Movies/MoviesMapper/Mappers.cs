using AutoMapper;
using API.J.Movies.DAL.Models;
using API.J.Movies.DAL.Models.Dtos;

namespace API.J.Movies.MoviesMapper
{
    public class Mappers : Profile
    {
            public Mappers()
            {
                // Category Mappings
                CreateMap<Category, CategoryDto>().ReverseMap();
                CreateMap<Category, CategoryCreateDto>().ReverseMap();

        }
    }
}
