using System;

namespace Interfacess
{
    public class Circle  : ICalculate
    {
        private int _number;
        public int Number { get{return _number;}set{_number=value;} }

        public int Calculate()
        {
            _number=(int)(Math.PI * Math.Pow(_number,2));
            return _number;
        }
    }
}
