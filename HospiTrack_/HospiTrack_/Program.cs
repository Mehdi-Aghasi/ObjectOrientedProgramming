using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiTrack_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hospital = Hospital.GetInstance();

            hospital.Rooms.Add(new Room { RoomNumber = 101, Capacity = 2 });
            hospital.Rooms.Add(new Room { RoomNumber = 102, Capacity = 1 });

            var doctor1 = PersonFactory.CreateDoctor(1, "Dr. Ali", 45, "12345", "Cardiology");
            var doctor2 = PersonFactory.CreateDoctor(2, "Dr. Sara", 38, "67890", "Neurology");
            hospital.Doctors.Add(doctor1);
            hospital.Doctors.Add(doctor2);

            var patient1 = PersonFactory.CreatePatient(1, "Reza", 30, "11111");
            var patient2 = PersonFactory.CreatePatient(2, "Mina", 25, "22222");
            var patient3 = PersonFactory.CreatePatient(3, "Omid", 40, "33333");

            hospital.AdmitPatient(patient1);
            hospital.AdmitPatient(patient2);
            hospital.AdmitPatient(patient3);

            doctor1.Diagnose(patient1, "Heart Disease");
            doctor2.Diagnose(patient2, "Migraine");

            hospital.DischargePatient(patient2);
        }
    }
    
}
