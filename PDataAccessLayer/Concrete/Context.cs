using Microsoft.EntityFrameworkCore;
using PEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDataAccessLayer.Concrete
{
   public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-HN2G937\\SQLSERVER;Initial Catalog=DbPharmacy;user id=sa; password=153624;integrated security=false;");
        }
        public DbSet<MedicineInfo> MedicineInfos { get; set; }
        public DbSet<PatientInfo> PatientInfos { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
    }
}
