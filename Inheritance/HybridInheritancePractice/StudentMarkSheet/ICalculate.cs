using System;

namespace StudentMarkSheet
{
    public interface ICalculate
    {
        int ProjectMark{get;set;}
        int CalculateUGTotal();
        int CalculateUGPercentage();
    }
}
