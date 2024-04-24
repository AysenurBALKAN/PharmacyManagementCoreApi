using PBusinessLayer.Abstract;
using PDataAccessLayer.Abstract;
using PEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBusinessLayer.Concrete
{
    public class ReceiptManager : IReceiptService
    {
        IReceiptDal _receiptDal;

        public ReceiptManager(IReceiptDal receiptDal)
        {
            _receiptDal = receiptDal;
        }

        public void TAdd(Receipt t)
        {
            _receiptDal.Insert(t);
        }

        public void TDelete(Receipt t)
        {
            _receiptDal.Delete(t);
        }

        

        public Receipt TGetById(int id)
        {
            return _receiptDal.GetlistById(id);
        }

        public List<Receipt> TGetList()
        {
            return _receiptDal.GetList();
        }

        public void TUpdate(Receipt t)
        {
            _receiptDal.Update(t);
        }
    }
}
