using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppStoreMobile.Entities
{
    [Table("products")]
    public class Products : BaseEntity
    {
        [Column("category_id")]
        public int? CategoryId { get; set; }

        [Required]
        [Column("name")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Column("slug")]
        [MaxLength(255)]
        public string Slug { get; set; }

        [Column("description", TypeName = "text")]
        public string? Description { get; set; }

        [Column("image")]
        [MaxLength(500)]
        public string? Image { get; set; }
    }
}