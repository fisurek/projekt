using System.ComponentModel.DataAnnotations.Schema;

namespace WypozyczalniaSamochodow.Models
{
    [Table("Data")]
    public class Data
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public String Color { get; set; }

        public int Power { get; set; }
        public float Capacity { get; set; }

        public Car? Car { get; set; }

        public string Information
        {
            get
            {
                return Power+ "V "+Capacity+"cm3 ("+Color+")";
            }
        }
    }
}
