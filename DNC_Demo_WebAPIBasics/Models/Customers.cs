using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNC_Demo_WebAPIBasics.Models
{
    [Table("tblCustomers")]
    public class Customers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }
        public string? Address { get; set; }        
        public string? Email { get; set; }    
        public string? MobileNumber { get; set; }

    }
}
