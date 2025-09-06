using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppStoreMobile.Entities
{
    [Table("product_attributes")]
    public class ProductAttributes : BaseEntity
    {
        [Required]
        [Column("attribute_name")]
        [MaxLength(255)]
        public string AttributeName { get; set; }

        [Required]
        [Column("attribute_value")]
        [MaxLength(255)]
        public string AttributeValue { get; set; }
    }
}