using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WypozyczalniaSamochodow.Models
{
    [Table("Contracts")]
    public class Contract
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [Range(0, 36)]
        public int NumberOfMonths { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }

        public int? CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }

        public int? CarId { get; set; }
        [ForeignKey("CarId")]
        public Car? Car { get; set; }
    }
}
