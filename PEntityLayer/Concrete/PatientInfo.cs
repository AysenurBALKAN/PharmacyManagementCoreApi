using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEntityLayer.Concrete
{
 public   class PatientInfo
    {
        [Key]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public int PatientPhoneNum { get; set; }
        public string Allergy { get; set; }
        public List<Receipt> Receipts { get; set; }
    }
}
