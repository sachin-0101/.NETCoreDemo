
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DNC_Demo_WebAPIBasics.Models
{
    [Table("tblProducts")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
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
