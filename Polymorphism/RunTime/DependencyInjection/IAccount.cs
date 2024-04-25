using System;

namespace DependencyInjection
{
    public interface IAccount
    {
        int AccountNumber{get;set;}
        string Name{get;set;}
        double Balance {get;set;}
    }
}
