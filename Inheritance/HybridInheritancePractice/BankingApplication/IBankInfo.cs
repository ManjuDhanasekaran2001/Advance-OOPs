using System;

namespace BankingApplication
{
    public interface IBankInfo
    {
        long AccounntNumber{get;set;}
        string IFSC {get;set;}
        string Branch{get;set;}
    }
}
