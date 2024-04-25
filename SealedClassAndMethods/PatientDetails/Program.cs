using System;
using PatientDetails;
namespace Patientdetails;
class Program{
    public static void Main(string[] args)
    {
        PatientInfo patient = new PatientInfo();
        patient.PatientID="PID1001";
        patient.PatientName="Ravi";
        patient.FatherName="Mani";
        patient.BedNo = 10;
        patient.NativePlace="Chennai";
        patient.AdmittedFor="General CheckUp";
        patient.Disaplay();
    }
}
