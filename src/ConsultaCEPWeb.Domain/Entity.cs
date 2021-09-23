using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultaCEPWeb.Domain
{
    public class Entity<T> where T : struct
    {
        [Key]
        [Column("Id")]
        public T Id { get; set; }
    }
}
