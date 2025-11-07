using System.ComponentModel.DataAnnotations;

namespace API.J.Movies.DAL.Models
{
    public class AuditBase
    {   // Decorators o data Annotations
        [Key]//PK 
        public   virtual int Id { get; set; }   // PK de todas las tablas 
        public virtual DateTime CreatedDate { get; set; } //este me sirve para guardas la fecha de creacion de un registro en BD   
        public virtual DateTime ModifiedDate { get; set; } //este me sirve para guardar la fecha de modificacion de un registro en BD

    }
}
