using System;

namespace OnlineMedicalStore
{
    public class MedicineDetails
    {
        private static int s_medicineID = 100;
        public string MedicineID { get; }
        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public double Price { get; set; }
        public DateTime DateOFExpiry { get; set; }



        public MedicineDetails(string medicineName,int availableCount,double price,DateTime dateOfExpiry)
        {
            s_medicineID++;
            MedicineID="MD"+s_medicineID;
            MedicineName = medicineName;
            AvailableCount  = availableCount;
            Price = price;
            DateOFExpiry= dateOfExpiry;
        }
    }
}
