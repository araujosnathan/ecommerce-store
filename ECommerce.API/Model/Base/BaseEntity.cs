using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.API.Model.Base
{
    public class BaseEntity
    {
       [Key]
       [Column("id")]
       public long Id { get; set; }
    }
}

