using System;

namespace DependencyInjection
{
    public class SABAcccount:IAccount
    {
        public int AccountNumber {get;set;}
        public string Name{get;set;}
        public double Balance {get;set;}
    }
}
