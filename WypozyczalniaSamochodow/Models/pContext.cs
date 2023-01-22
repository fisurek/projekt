using Microsoft.EntityFrameworkCore;
using WypozyczalniaSamochodow.Models;

namespace WypozyczalniaSamochodow.Models
{
    public class pContext :DbContext
    {
        public pContext(DbContextOptions<pContext> options):base(options) { }
        public DbSet<WypozyczalniaSamochodow.Models.Car> Car { get; set; } = default!;
        public DbSet<WypozyczalniaSamochodow.Models.Contract> Contract { get; set; } = default!;
        public DbSet<WypozyczalniaSamochodow.Models.Customer> Customer { get; set; } = default!;
        public DbSet<WypozyczalniaSamochodow.Models.Data> Data { get; set; } = default!;
    }
}
