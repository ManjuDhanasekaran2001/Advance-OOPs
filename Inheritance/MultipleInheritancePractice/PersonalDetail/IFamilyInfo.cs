using System;

namespace PersonalDetail
{
    public interface IFamilyInfo:IShowData
    {
        string FatherName {get;set;}
        string MotherName {get;set;}
        string HouseAddress {get;set;}
        int NoOfSibilings {get;set;}
    
    }

    
}
