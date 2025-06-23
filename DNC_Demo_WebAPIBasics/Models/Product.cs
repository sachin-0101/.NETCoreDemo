using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNC_Demo_WebAPIBasics.Models
{
    [Table("tblProducts")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(50, MinimumLength =3)]
        public string? Name { get; set; }
        [MaxLength(50)]
        public string? Description { get; set; }

        [DataType(DataType.Currency)]
        public int Price { get; set; }
    }
}
