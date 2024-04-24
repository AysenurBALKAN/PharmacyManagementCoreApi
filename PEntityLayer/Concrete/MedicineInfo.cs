using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEntityLayer.Concrete
{
  public  class MedicineInfo
    {
        [Key]
        public int MedicineBarcode { get; set; }
        public string MedicineName { get; set; }
        public string ActiveIngredient { get; set; }
        public string Instructions { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Piece { get; set; }
        public List<Receipt> Receipts { get; set; }
    }
}
