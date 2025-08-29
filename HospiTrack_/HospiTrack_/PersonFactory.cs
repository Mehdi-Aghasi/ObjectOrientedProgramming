using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiTrack_
{
    static class PersonFactory
    {
        public static Patient CreatePatient(int id, string name, int age, string nationalId)
        {
            return new Patient
            {
                PatientId = id,
                Name = name,
                Age = age,
                NationalId = nationalId
            };
        }

        public static Doctor CreateDoctor(int id, string name, int age, string nationalId, string specialization)
        {
            return new Doctor(specialization)
            {
                DoctorId = id,
                Name = name,
                Age = age,
                NationalId = nationalId
            };
        }
    }
}
