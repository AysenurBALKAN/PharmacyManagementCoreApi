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
    public class PatientManager : IPatientService
    {
        IPatientDal _patientDal;

        public PatientManager(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }

        public void TAdd(PatientInfo t)
        {
            _patientDal.Insert(t);
        }

        public void TDelete(PatientInfo t)
        {
            _patientDal.Delete(t);
        }

        

        public PatientInfo TGetById(int id)
        {
          return  _patientDal.GetlistById(id);
        }

        public List<PatientInfo> TGetList()
        {
            return _patientDal.GetList();
        }

        public void TUpdate(PatientInfo t)
        {
            _patientDal.Update(t);
        }
    }
}
