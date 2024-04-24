using PDataAccessLayer.Abstract;
using PDataAccessLayer.Repository;
using PEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDataAccessLayer.EntityFramework
{
   public class EfReceipt:GenericRepository<Receipt>,IReceiptDal
    {

    }
}
