using System;
namespace Inside
{
    public class Second:First
    {
       public int ProtectedNumberOut{get{return ProtectedNumber;}} 

       //internal protected int InternalProtected = 40;
    }
}
