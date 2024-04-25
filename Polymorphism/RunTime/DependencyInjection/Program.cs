using System;
using System.Collections.Generic;
using DependencyInjection;
namespace DeoendencyInjection;
class Proggram{
    public static void Main(string[] args)
    {
        CCAccount ccAccount = new CCAccount();
        ccAccount.AccountNumber=1123;
        ccAccount.Name= "manju";
        ccAccount.Balance=10000000000;

        SABAcccount sabaAccount = new SABAcccount();
        sabaAccount.AccountNumber=1234;
        sabaAccount.Name="Priya";
        sabaAccount.Balance=12300000;


        List<CCAccount> ccList = new List<CCAccount>();
        ccList.Add(ccAccount);

        List<SABAcccount> sbList = new List<SABAcccount>();
        sbList.Add(sabaAccount);

        List<IAccount> accountListt = new List<IAccount>();
        accountListt.Add(ccAccount);
        accountListt.Add(sabaAccount);
            
            
            }
            
}
