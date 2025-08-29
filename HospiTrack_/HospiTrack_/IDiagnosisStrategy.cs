using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiTrack_
{
    internal interface IDiagnosisStrategy
    {
        void Diagnose(Patient patient, string disease);
    }
    class CardiologyStrategy : IDiagnosisStrategy
    {
        public void Diagnose(Patient patient, string disease)
        {
            patient.AddToMedicalHistory($"Cardiology {disease}");
            Console.WriteLine($"Cardiology diagnosis added for {patient.Name}: {disease}");
        }
    }

    class NeurologyStrategy : IDiagnosisStrategy
    {
        public void Diagnose(Patient patient, string disease)
        {
            patient.AddToMedicalHistory($"Neurology {disease}");
            Console.WriteLine($"Neurology diagnosis added for {patient.Name}: {disease}");
        }
    }

    class GeneralStrategy : IDiagnosisStrategy
    {
        public void Diagnose(Patient patient, string disease)
        {
            patient.AddToMedicalHistory($"General {disease}");
            Console.WriteLine($"General diagnosis added for {patient.Name}: {disease}");
        }
    }

}
