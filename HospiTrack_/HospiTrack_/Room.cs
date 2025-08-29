using System;
using System.Collections.Generic;

namespace HospiTrack_
{
    class Room
    {
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();

        public void AssignPatient(Patient patient)
        {
            if (Patients.Count >= Capacity)
                throw new RoomFullException($"Room {RoomNumber} is full!");
            Patients.Add(patient);
        }
    }
}
