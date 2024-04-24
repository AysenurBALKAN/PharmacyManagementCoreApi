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
    public class MedicineManager : IMedicineService
    {
        IMedicineDal _medicineDal;

        public MedicineManager(IMedicineDal medicineDal)
        {
            _medicineDal = medicineDal;
        }

        public void TAdd(MedicineInfo t)
        {
            _medicineDal.Insert(t);
        }

        public void TDelete(MedicineInfo t)
        {
            _medicineDal.Delete(t);
        }

        
        public MedicineInfo TGetById(int id)
        {
           return _medicineDal.GetlistById(id);
        }

        public List<MedicineInfo> TGetList()
        {
            return _medicineDal.GetList();
        }

        public void TUpdate(MedicineInfo t)
        {
            _medicineDal.Update(t);
        }
    }
}
