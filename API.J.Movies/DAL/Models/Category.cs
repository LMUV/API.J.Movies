using System.ComponentModel.DataAnnotations;

namespace API.J.Movies.DAL.Models
{
    public class Category : AuditBase
    {
        //propiedades!! se convierten en columnas en la base de datos

        [Required] // este decorador indica que el campo es obligatorio (no acepta nulls)
        [Display(Name = "Nombre de la categoria")] // este decorador sirve para mostrar un nombre amigable en las vistas o UI
        public required string Name { get; set; }

    }

}
/*
 * Categories
 * --Id
 * --name
 * --CreatedDate
 * --ModifiedDate
 */