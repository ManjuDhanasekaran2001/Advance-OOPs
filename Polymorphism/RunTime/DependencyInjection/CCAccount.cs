using System;

namespace DependencyInjection
{
    public class CCAccount : IAccount
    {
        public int AccountNumber{get; set;}
        public string Name {get;set;}
        public  double Balance {get;set;}
    }
}
