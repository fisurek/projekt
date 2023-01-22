using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WypozyczalniaSamochodow.Models
{
    [Table("Cars")]
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public String Name { get; set; }

        public ICollection<Contract>? Contracts { get; set; }

        public int? DataId { get; set; }

        [ForeignKey("DataId")]
        public Data? Data { get; set; }

        public string Information
        {
            get
            {
               return Name +" (ID: "+Id+")";
            }
        }
    }
}
