using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiTrack_
{
    class Hospital
    {
        private static Hospital instance;

        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Room> Rooms { get; set; } = new List<Room>();

        private Hospital() { } 

        public static Hospital GetInstance()
        {
            if (instance == null)
                instance = new Hospital();
            return instance;
        }

        public void AdmitPatient(Patient patient)
        {
            bool admitted = false;
            foreach (var room in Rooms)
            {
                try
                {
                    room.AssignPatient(patient);
                    Console.WriteLine($"Patient {patient.Name} admitted to Room {room.RoomNumber}");
                    admitted = true;
                    break;
                }
                catch (RoomFullException)
                {
                    
                }
            }
            if (!admitted)
                Console.WriteLine("No available room for admission!");
        }

        public void DischargePatient(Patient patient)
        {
            foreach (var room in Rooms)
            {
                if (room.Patients.Contains(patient))
                {
                    room.Patients.Remove(patient);
                    Console.WriteLine($"Patient {patient.Name} discharged from Room {room.RoomNumber}");
                    return;
                }
            }
            Console.WriteLine($"Patient {patient.Name} not found in any room!");
        }
    }
}
