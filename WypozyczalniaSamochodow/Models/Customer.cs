using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WypozyczalniaSamochodow.Models
{
    [Table("Customers")]
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }

        public ICollection<Contract>? Contracts { get; set; }

        public string name
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
