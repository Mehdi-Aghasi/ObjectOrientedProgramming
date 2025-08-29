using System;
using System.Collections.Generic;

namespace HospiTrack_
{
    class Doctor : Person
    {
        public int DoctorId { get; set; }
        public string Specialization { get; set; }

        private IDiagnosisStrategy diagnosisStrategy;

        public Doctor(string specialization)
        {
            Specialization = specialization;

            switch (specialization.ToLower())
            {
                case "cardiology":
                    diagnosisStrategy = new CardiologyStrategy();
                    break;
                case "neurology":
                    diagnosisStrategy = new NeurologyStrategy();
                    break;
                default:
                    diagnosisStrategy = new GeneralStrategy();
                    break;
            }
        }

        public void Diagnose(Patient patient, string disease)
        {
            diagnosisStrategy.Diagnose(patient, disease);
        }
    }
}
