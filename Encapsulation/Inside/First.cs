using System;
using Outside;
namespace Inside

{
    public class First :Third
    {
        public int InternalProtectedout {get{return InternalProtected;}}
        private int _privateNumber = 10;

        public int PrivateOut { get{return _privateNumber;}}

        public int PublicNumber = 20;
        protected int ProtectedNumber=30;
    }
}
