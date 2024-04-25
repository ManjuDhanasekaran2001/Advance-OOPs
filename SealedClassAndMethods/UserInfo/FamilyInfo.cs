using System;

namespace UserInfo
{
    public class FamilyInfo:PersonalInfo
    {
        public string MotherName { get; set; }
        public int NoOfSibilings { get; set; }
        public string NativePlace { get; set; }


        public sealed override void Update(string name, string fatherNmaee, string gender, string phoneNo, string mailID)
        {
            base.Update(name, fatherNmaee, gender, phoneNo, mailID);
        }

        
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"motherName : {MotherName}");
            Console.WriteLine($"NoOFSibiling : { NoOfSibilings}");

        }
    }
}
