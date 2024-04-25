using System;

namespace BankingApplication
{
    public class IDInfo:PersonalInfo
    {
        public string VoterID { get; set; }
        public long AdharID { get; set; }

        public string PANNumber { get; set; }
    }
}
