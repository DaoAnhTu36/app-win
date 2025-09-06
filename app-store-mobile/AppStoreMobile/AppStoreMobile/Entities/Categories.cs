using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppStoreMobile.Entities
{
    [Table("categories")]
    public class Categories : BaseEntity
    {
        [Column("name", TypeName = "varchar(255)")]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Column("description", TypeName = "text")]
        public string? Description { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("is_display")]
        public bool? IsDisplay { get; set; }
    }
}