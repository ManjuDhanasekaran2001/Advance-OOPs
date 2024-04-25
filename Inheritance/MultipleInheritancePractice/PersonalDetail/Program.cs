using System;
using System.Runtime.InteropServices;
using PersonalDetail;
namespace PersonalDetails;
class Program{
    public static void Main(string[] args)
    {
       RegisterPerson person1 = new RegisterPerson("manju","Female","12/09/2001","8790867890",MaritalDetail.Single,"Dhana","Renu","2/250 rr street",4,"12/04/2023");
       person1.ShowInfo();
        RegisterPerson person2 = new RegisterPerson("saki","Female","12/12/2001","8790867890",MaritalDetail.Single,"Mani","selvi","2a sr street",4,"12/05/2023");
       person2.ShowInfo();
    }
}
