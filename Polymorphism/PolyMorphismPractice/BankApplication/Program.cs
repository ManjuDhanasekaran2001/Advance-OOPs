using System;
namespace BankApplication;
class Program{
    public static void Main(string[] args)
    {
        Bank sbi = new SBI(40000);
        Console.WriteLine($"SBI Interset :  {sbi.GetInterestInfo()}");
        Console.WriteLine(" ");
        Bank idbi = new IDBI(50000);
        Console.WriteLine($"IDBI Interset :  {idbi.GetInterestInfo()}");
        Console.WriteLine(" ");

        Bank icici = new ICICI(30000);
        Console.WriteLine($"ICICI Interset :  {icici.GetInterestInfo()}");    
        Console.WriteLine(" ");
        Bank hdfc = new ICICI(20000);
        Console.WriteLine($"HDFC Interset :  {hdfc.GetInterestInfo()}");    

    }
}