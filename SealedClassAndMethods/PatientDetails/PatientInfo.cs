using System;

namespace PatientDetails
{
    public sealed class PatientInfo
    {
        public string PatientID{ get; set; }
        public string PatientName { get; set; }
        public string FatherName { get; set; }
        public int BedNo { get; set; }
        public string NativePlace{ get; set; }
        public string AdmittedFor{ get; set; }

        public void Disaplay(){
            Console.WriteLine($"PatientID = { PatientID}");
             Console.WriteLine($"Patientname : {PatientName}");
              Console.WriteLine($"FatherName : {FatherName}");
               Console.WriteLine($"BedNo : {BedNo}");
                Console.WriteLine($"NativePlace : {NativePlace}");
                 Console.WriteLine($"AdmittedFor : {AdmittedFor}");
        }
        
    }
}
