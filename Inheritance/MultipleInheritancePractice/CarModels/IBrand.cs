using System;
using System.Dynamic;

namespace CarModels
{
    public interface IBrand
    {
        string BrandName{get;set;}
        string ModelName{get;set;}

        void ShowDetails();
    }
}
