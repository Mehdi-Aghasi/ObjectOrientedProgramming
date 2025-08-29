using System;
using System.Collections.Generic;

namespace HospiTrack_
{
    class Patient : Person
    {
        public int PatientId { get; set; }
        public List<string> MedicalHistory { get; set; } = new List<string>();

        public void AddToMedicalHistory(string disease)
        {
            MedicalHistory.Add(disease);
        }
    }
}
